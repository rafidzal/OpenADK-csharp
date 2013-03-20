// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.us.Student
{
	///<summary>
	/// Defines the set of values that can be specified whenever a FTPTStatus
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a FTPTStatus object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	[Serializable]
	public class FTPTStatus : SifEnum
	{
	/// <summary>FullTime ("FullTime")</summary>
	public static readonly FTPTStatus FULLTIME = new FTPTStatus("FullTime");

	/// <summary>PartTime ("PartTime")</summary>
	public static readonly FTPTStatus PARTTIME = new FTPTStatus("PartTime");

	///<summary>Wrap an arbitrary string value in a FTPTStatus object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static FTPTStatus Wrap( String wrappedValue ) {
		return new FTPTStatus( wrappedValue );
	}

	private FTPTStatus( string enumDefValue ) : base( enumDefValue ) {}
	}
}
