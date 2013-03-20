// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.au.System
{
	///<summary>
	/// Defines the set of values that can be specified whenever a SystemRoleObjectType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a SystemRoleObjectType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	[Serializable]
	public class SystemRoleObjectType : SifEnum
	{
	/// <summary>Identity ("Identity")</summary>
	public static readonly SystemRoleObjectType IDENTITY = new SystemRoleObjectType("Identity");

	/// <summary>StudentContactPersonal ("StudentContactPersonal")</summary>
	public static readonly SystemRoleObjectType STUDENT_CONTACT_PERSONAL = new SystemRoleObjectType("StudentContactPersonal");

	/// <summary>StaffPersonal ("StaffPersonal")</summary>
	public static readonly SystemRoleObjectType STAFF_PERSONAL = new SystemRoleObjectType("StaffPersonal");

	/// <summary>StudentPersonal ("StudentPersonal")</summary>
	public static readonly SystemRoleObjectType STUDENT_PERSONAL = new SystemRoleObjectType("StudentPersonal");

	///<summary>Wrap an arbitrary string value in a SystemRoleObjectType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static SystemRoleObjectType Wrap( String wrappedValue ) {
		return new SystemRoleObjectType( wrappedValue );
	}

	private SystemRoleObjectType( string enumDefValue ) : base( enumDefValue ) {}
	}
}
