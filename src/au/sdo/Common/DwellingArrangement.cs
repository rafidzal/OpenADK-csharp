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

namespace OpenADK.Library.au.Common{

/// <summary>A DwellingArrangement</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.3</para>
/// </remarks>
[Serializable]
public class DwellingArrangement : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a DwellingArrangement
	/// </summary>
	public DwellingArrangement() : base ( CommonDTD.DWELLINGARRANGEMENT ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="code">
	/// Code representing the setting/environment in which the
	/// person resides</param>
	///
	public DwellingArrangement( AU0600DwellingArrangementType code ) : base( CommonDTD.DWELLINGARRANGEMENT )
	{
		this.SetCode( code );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected DwellingArrangement( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { CommonDTD.DWELLINGARRANGEMENT_CODE }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Code&gt;</c> element.
	/// </summary>
	/// <value> The <c>Code</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "
	/// Code representing the setting/environment in which the
	/// person resides"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string Code
	{
		get
		{ 
			return GetFieldValue( CommonDTD.DWELLINGARRANGEMENT_CODE );
		}
		set
		{
			SetField( CommonDTD.DWELLINGARRANGEMENT_CODE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;Code&gt;</c> element.
	/// </summary>
	/// <param name="val">A AU0600DwellingArrangementType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "
	/// Code representing the setting/environment in which the
	/// person resides"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetCode( AU0600DwellingArrangementType val )
	{
		SetField( CommonDTD.DWELLINGARRANGEMENT_CODE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;OtherIdList&gt;</c> element.
	/// </summary>
	/// <value> An OtherIdList </value>
	/// <remarks>
	/// <para>To remove the <c>OtherIdList</c>, set <c>OtherIdList</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public OtherIdList OtherIdList
	{
		get
		{
			return (OtherIdList)GetChild( CommonDTD.DWELLINGARRANGEMENT_OTHERIDLIST);
		}
		set
		{
			RemoveChild( CommonDTD.DWELLINGARRANGEMENT_OTHERIDLIST);
			if( value != null)
			{
				AddChild( CommonDTD.DWELLINGARRANGEMENT_OTHERIDLIST, value );
			}
		}
	}

}}
