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
using OpenADK.Library.au.Common;

namespace OpenADK.Library.au.Sif3assessment{

/// <summary>A SubTestIdentifier</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.6</para>
/// </remarks>
[Serializable]
public class SubTestIdentifier : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a SubTestIdentifier
	/// </summary>
	public SubTestIdentifier() : base ( Sif3assessmentDTD.SUBTESTIDENTIFIER ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="value">Gets or sets the content value of the &amp;lt;SubTestIdentifier&amp;gt; element</param>
	///
	public SubTestIdentifier( string value ) : base( Sif3assessmentDTD.SUBTESTIDENTIFIER )
	{
		this.Value = value;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected SubTestIdentifier( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { Sif3assessmentDTD.SUBTESTIDENTIFIER }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SubTestIdentifier&gt;</c> element.
	/// </summary>
	/// <value> The <c>Value</c> of the content of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this of the content as: "Gets or sets the content value of the &amp;lt;SubTestIdentifier&amp;gt; element"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string Value
	{
		get
		{
			return (string) GetSifSimpleFieldValue( Sif3assessmentDTD.SUBTESTIDENTIFIER ) ;
		}
		set
		{
			SetFieldValue( Sif3assessmentDTD.SUBTESTIDENTIFIER, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>SubTestIdentifierType</c> attribute.
	/// </summary>
	/// <value> The <c>SubTestIdentifierType</c> attribute of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string SubTestIdentifierType
	{
		get
		{ 
			return GetFieldValue( Sif3assessmentDTD.SUBTESTIDENTIFIER_SUBTESTIDENTIFIERTYPE );
		}
		set
		{
			SetField( Sif3assessmentDTD.SUBTESTIDENTIFIER_SUBTESTIDENTIFIERTYPE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>SubTestIdentifierType</c> attribute.
	/// </summary>
	/// <param name="val">A AssetIdType object</param>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetSubTestIdentifierType( AssetIdType val )
	{
		SetField( Sif3assessmentDTD.SUBTESTIDENTIFIER_SUBTESTIDENTIFIERTYPE, val );
	}

}}
