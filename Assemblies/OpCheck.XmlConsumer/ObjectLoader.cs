﻿using System;
using System.Reflection;

namespace OpCheck.XmlConsumer
{
	/// <summary>
	/// Set values on the target object.
	/// </summary>
	public class ObjectLoader
	{
		public void Init ()
		{
			//
			// GET THE TARGET OBJECT'S TYPE.
			//
			_TargetObjectType = _TargetObject.GetType();
		}
		
		
		/// <summary>
		/// Gets the type of the member or type of the parameter for a single-parameter function.
		/// </summary>
		public Type GetMemberTypeByName (string MemberName)
		{
			if (HasFieldWithName(MemberName))
				return GetFieldTypeByName(MemberName);
				
			if (HasSetterWithName(MemberName))
				return GetPropertyTypeByName(MemberName);
			
			if (HasMethodWithName(MemberName))
				return GetMethodByName(MemberName).GetParameters()[0].ParameterType;
			
			//
			// AT THIS POINT WE COULD NOT FIND A MATCHING MEMBER.
			//
			MemberNotFoundException CreatedException = new MemberNotFoundException();
			CreatedException.MemberName = MemberName;
			CreatedException.TargetObjectType = _TargetObjectType;
			throw CreatedException;
		}
		
		
		public object GetMemberObjectByName (string MemberName)
		{
			//
			// TRY GETTING A FIELD.
			//
			if (HasFieldWithName(MemberName))
				return GetFieldObjectByName(MemberName);

			//
			// TRY GETTING A PROPERTY WITH A GETTER.
			// THE LIKELY INTENT IS THAT WE ARE GOING TO USE THIS OBJECT AS THE NEW CONTEXT OBJECT - SO A GETTER MUST EXIST SO THE SYSTEM CAN OBTAIN A REFERENCE TO THAT OBJECT.
			//
			if (HasGetterWithName(MemberName))
				return GetPropertyObjectByName(MemberName);

			return null;
		}


		public object GetFieldObjectByName (string MemberName)
		{
			return _TargetObjectType.GetField(MemberName).GetValue(_TargetObject);
		}


		public object GetPropertyObjectByName (string MemberName)
		{
			return _TargetObjectType.GetProperty(MemberName);
		}


		public bool HasMethodWithName (string MemberName)
		{
			return _TargetObjectType.GetMethod(MemberName) != null;
		}
		
		
		public MethodInfo GetMethodByName (string MemberName)
		{
			return _TargetObjectType.GetMethod(MemberName);
		}
		
		
		public Type GetFieldTypeByName (string MemberName)
		{
			return _TargetObjectType.GetField(MemberName).FieldType;
		}


		public Type GetPropertyTypeByName (string MemberName)
		{
			return _TargetObjectType.GetProperty(MemberName).PropertyType;
		}


		public Type GetMatchingMethodArgType (string MemberName, object Value)
		{
			return GetMatchingMethod(MemberName, Value).GetParameters()[0].ParameterType;
		}
		
		
		public MethodInfo GetMatchingMethod (string MemberName, object Value)
		{
			return _TargetObjectType.GetMethod(MemberName, new Type[]{Value.GetType()});
		}

	
		public void SetMemberValue (string MemberName, object Value)
		{
			//
			// SET THE FIELD VALUE.
			//
			if (HasFieldWithName(MemberName))
			{
				_TargetObjectType.GetField(MemberName).SetValue(_TargetObject, Value);
				return;
			}
			
			//
			// SET THE PROPERTY VALUE.
			//
			if (HasSetterWithName(MemberName))
			{
				_TargetObjectType.GetProperty(MemberName).GetSetMethod().Invoke(_TargetObject, new object[]{Value});
				return;
			}
			
			//
			// CALL THE METHOD.
			//
			if (HasMatchingMethod(MemberName, Value))
			{
				_TargetObjectType.GetMethod(MemberName, new Type[]{Value.GetType()}).Invoke(_TargetObject, new object[]{Value});
				return;
			}
			
			//
			// IF NO MEMBER WAS FOUND, THEN WHAT DO WE DO?
			//
			
			//
			// WE COULD THROW AN EXCEPTION IF CONFIGURED TO DO SO.
			//
			
			//
			// WE COULD DO SOMETHING ELSE WITH THE MEMBER NAME AND VALUE.
			//
			
			//
			// VERTICAL SCREEN HAD AN ADDITIONAL FIELDS OBJECT.
			//
		}
		
		
		public object CreateInstanceOfMemberByName (string MemberName)
		{
			//
			// GET THE TARGET MEMBER'S CONSTRUCTOR.
			//
			ObjectReflector ContextObjectReflector = new ObjectReflector();
			ContextObjectReflector.TargetObject = _TargetObject;
			ContextObjectReflector.Init();
			ConstructorInfo MemberConstructor = ContextObjectReflector.GetMemberConstructorByName(MemberName);
			
			//
			// CREATE THE TARGET MEMBER USING THE DEFAULT CONSTRUCTOR.
			//
			object CreatedMember = MemberConstructor.Invoke(new object[0]{});
			
			//
			// SET THE TARGET MEMBER ON THE CONTEXT OBJECT.
			//
			SetMemberValue(MemberName, CreatedMember);
			
			//
			// RETURN THE CREATED MEMBER FOR CONVENIENCE.
			//
			return GetMemberObjectByName(MemberName);
		}
		
		
		public bool HasFieldWithName (string Name)
		{
			return _TargetObjectType.GetField(Name) != null;
		}


		public bool HasSetterWithName (string Name)
		{
			return HasPropertyWithName(Name) && _TargetObjectType.GetProperty(Name).GetSetMethod() != null;
		}


		public bool HasGetterWithName (string Name)
		{
			return HasPropertyWithName(Name) && _TargetObjectType.GetProperty(Name).GetGetMethod() != null;
		}
		
		
		public bool HasPropertyWithName (string Name)
		{
			return _TargetObjectType.GetProperty(Name) != null;
		}
		
		
		public bool HasMatchingMethod (string Name, object Value)
		{
			return _TargetObjectType.GetMethod(Name, new Type[]{Value.GetType()}) != null;
		}
		
		
		public object TargetObject
		{
			set
			{
				_TargetObject = value;
			}
		}


		//
		// INPUT FIELDS.
		//
		private object _TargetObject;
		
		//
		// OPERATIONAL FIELDS.
		//
		private Type _TargetObjectType;
	}
}
