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
using OpenADK.Library.uk.Common;

namespace OpenADK.Library.uk.Learning{

/// <summary>A NonTeachingActivity</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.3</para>
/// </remarks>
[Serializable]
public class NonTeachingActivity : SifDataObject
{
	/// <summary>
	/// Creates an instance of a NonTeachingActivity
	/// </summary>
	public NonTeachingActivity() : base( Adk.SifVersion, LearningDTD.NONTEACHINGACTIVITY ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">A unique local identifier for this junction</param>
	///<param name="ntCode">A NTCode</param>
	///<param name="description">A Description</param>
	///<param name="type">Lesson/meeting type Note this Type over-rides the period type in the cycle definition (in case, for eg, Period 1 is Registration for some classes but not others)</param>
	///
	public NonTeachingActivity( string refId, string ntCode, string description, NonTeachingActivityType type ) : base( Adk.SifVersion, LearningDTD.NONTEACHINGACTIVITY )
	{
		this.RefId = refId;
		this.NTCode = ntCode;
		this.Description = description;
		this.SetType( type );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected NonTeachingActivity( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { LearningDTD.NONTEACHINGACTIVITY_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "A unique local identifier for this junction"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( LearningDTD.NONTEACHINGACTIVITY_REFID ) ;
		}
		set
		{
			SetFieldValue( LearningDTD.NONTEACHINGACTIVITY_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;NTCode&gt;</c> element.
	/// </summary>
	/// <value> The <c>NTCode</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string NTCode
	{
		get
		{
			return (string) GetSifSimpleFieldValue( LearningDTD.NONTEACHINGACTIVITY_NTCODE ) ;
		}
		set
		{
			SetFieldValue( LearningDTD.NONTEACHINGACTIVITY_NTCODE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Description&gt;</c> element.
	/// </summary>
	/// <value> The <c>Description</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string Description
	{
		get
		{
			return (string) GetSifSimpleFieldValue( LearningDTD.NONTEACHINGACTIVITY_DESCRIPTION ) ;
		}
		set
		{
			SetFieldValue( LearningDTD.NONTEACHINGACTIVITY_DESCRIPTION, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Type&gt;</c> element.
	/// </summary>
	/// <value> The <c>Type</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Lesson/meeting type Note this Type over-rides the period type in the cycle definition (in case, for eg, Period 1 is Registration for some classes but not others)"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string Type
	{
		get
		{ 
			return GetFieldValue( LearningDTD.NONTEACHINGACTIVITY_TYPE );
		}
		set
		{
			SetField( LearningDTD.NONTEACHINGACTIVITY_TYPE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;Type&gt;</c> element.
	/// </summary>
	/// <param name="val">A NonTeachingActivityType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Lesson/meeting type Note this Type over-rides the period type in the cycle definition (in case, for eg, Period 1 is Registration for some classes but not others)"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetType( NonTeachingActivityType val )
	{
		SetField( LearningDTD.NONTEACHINGACTIVITY_TYPE, val );
	}

}}
