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

/// <summary>A Duration</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.6</para>
/// </remarks>
[Serializable]
public class Duration : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a Duration
	/// </summary>
	public Duration() : base ( Sif3assessmentDTD.DURATION ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="units">An Units</param>
	///<param name="value">Gets or sets the content value of the &amp;lt;Duration&amp;gt; element</param>
	///
	public Duration( TimeUnitEnum units, int? value ) : base( Sif3assessmentDTD.DURATION )
	{
		this.SetUnits( units );
		this.Value = value;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Duration( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { Sif3assessmentDTD.DURATION_UNITS }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Duration&gt;</c> element.
	/// </summary>
	/// <value> The <c>Value</c> of the content of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this of the content as: "Gets or sets the content value of the &amp;lt;Duration&amp;gt; element"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public int? Value
	{
		get
		{
			return (int?) GetSifSimpleFieldValue( Sif3assessmentDTD.DURATION ) ;
		}
		set
		{
			SetFieldValue( Sif3assessmentDTD.DURATION, new SifInt( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>Units</c> attribute.
	/// </summary>
	/// <value> The <c>Units</c> attribute of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string Units
	{
		get
		{ 
			return GetFieldValue( Sif3assessmentDTD.DURATION_UNITS );
		}
		set
		{
			SetField( Sif3assessmentDTD.DURATION_UNITS, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>Units</c> attribute.
	/// </summary>
	/// <param name="val">A TimeUnitEnum object</param>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetUnits( TimeUnitEnum val )
	{
		SetField( Sif3assessmentDTD.DURATION_UNITS, val );
	}

}}