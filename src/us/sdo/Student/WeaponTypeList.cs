// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using System.Text;
using System.Security.Permissions;
using System.Runtime.Serialization;
using OpenADK.Library;
using OpenADK.Library.Global;
using OpenADK.Library.us.Common;

namespace OpenADK.Library.us.Student{

/// <summary>A WeaponTypeList</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class WeaponTypeList : SifKeyedList<WeaponType>
{
	/// <summary>
	/// Creates an instance of a WeaponTypeList
	/// </summary>
	public WeaponTypeList() : base ( StudentDTD.WEAPONTYPELIST ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="weaponType">Identifies the type of weapon used during an incident.</param>
	///
	public WeaponTypeList( WeaponType weaponType ) : base( StudentDTD.WEAPONTYPELIST )
	{
		this.SafeAddChild( StudentDTD.WEAPONTYPELIST_WEAPONTYPE, weaponType );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected WeaponTypeList( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	///<summary>Adds the value of the <c>&lt;WeaponType&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;WeaponType&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setWeaponType</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddWeaponType</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void AddWeaponType( WeaponTypeCode Value ) {
		AddChild( StudentDTD.WEAPONTYPELIST_WEAPONTYPE, new WeaponType( Value ) );
	}

}}
