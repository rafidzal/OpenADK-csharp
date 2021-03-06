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
using OpenADK.Library.us.Gradebook;
using OpenADK.Library.us.Student;

namespace OpenADK.Library.us.Etranscripts{

/// <summary>An ActivityAward</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class ActivityAward : SifElement
{
	/// <summary>
	/// Creates an instance of an ActivityAward
	/// </summary>
	public ActivityAward() : base ( EtranscriptsDTD.ACTIVITYAWARD ){}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected ActivityAward( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets or sets the value of the <c>&lt;Name&gt;</c> element.
	/// </summary>
	/// <value> The <c>Name</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The title that identifies a particular co-curricular or extra-curricular activity."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string Name
	{
		get
		{
			return (string) GetSifSimpleFieldValue( EtranscriptsDTD.ACTIVITYAWARD_NAME ) ;
		}
		set
		{
			SetFieldValue( EtranscriptsDTD.ACTIVITYAWARD_NAME, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;InvolvementCode&gt;</c> element.
	/// </summary>
	/// <value> The <c>InvolvementCode</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The code used to identify the co-curricular or extra-curricular activity in which the individual is involved."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string InvolvementCode
	{
		get
		{ 
			return GetFieldValue( EtranscriptsDTD.ACTIVITYAWARD_INVOLVEMENTCODE );
		}
		set
		{
			SetField( EtranscriptsDTD.ACTIVITYAWARD_INVOLVEMENTCODE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;InvolvementCode&gt;</c> element.
	/// </summary>
	/// <param name="val">A ActivityInvolvementCode object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The code used to identify the co-curricular or extra-curricular activity in which the individual is involved."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetInvolvementCode( ActivityInvolvementCode val )
	{
		SetField( EtranscriptsDTD.ACTIVITYAWARD_INVOLVEMENTCODE, val );
	}

	///<summary>Sets the value of the <c>&lt;InvolvementBeginningDate&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;PartialDateType&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setInvolvementBeginningDate</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>InvolvementBeginningDate</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetInvolvementBeginningDate( string Value ) {
		RemoveChild( EtranscriptsDTD.ACTIVITYAWARD_INVOLVEMENTBEGINNINGDATE);
		AddChild( EtranscriptsDTD.ACTIVITYAWARD_INVOLVEMENTBEGINNINGDATE, new PartialDateType( Value ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;InvolvementBeginningDate&gt;</c> element.
	/// </summary>
	/// <value> A PartialDateType </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "The month, day, and year on which the individual began to participate in the activity."</para>
	/// <para>To remove the <c>PartialDateType</c>, set <c>InvolvementBeginningDate</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public PartialDateType InvolvementBeginningDate
	{
		get
		{
			return (PartialDateType)GetChild( EtranscriptsDTD.ACTIVITYAWARD_INVOLVEMENTBEGINNINGDATE);
		}
		set
		{
			RemoveChild( EtranscriptsDTD.ACTIVITYAWARD_INVOLVEMENTBEGINNINGDATE);
			if( value != null)
			{
				AddChild( EtranscriptsDTD.ACTIVITYAWARD_INVOLVEMENTBEGINNINGDATE, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;InvolvementEndingDate&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;PartialDateType&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setInvolvementEndingDate</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>InvolvementEndingDate</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetInvolvementEndingDate( string Value ) {
		RemoveChild( EtranscriptsDTD.ACTIVITYAWARD_INVOLVEMENTENDINGDATE);
		AddChild( EtranscriptsDTD.ACTIVITYAWARD_INVOLVEMENTENDINGDATE, new PartialDateType( Value ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;InvolvementEndingDate&gt;</c> element.
	/// </summary>
	/// <value> A PartialDateType </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "The month, day, and year on which the individual ceased to participate in the activity."</para>
	/// <para>To remove the <c>PartialDateType</c>, set <c>InvolvementEndingDate</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public PartialDateType InvolvementEndingDate
	{
		get
		{
			return (PartialDateType)GetChild( EtranscriptsDTD.ACTIVITYAWARD_INVOLVEMENTENDINGDATE);
		}
		set
		{
			RemoveChild( EtranscriptsDTD.ACTIVITYAWARD_INVOLVEMENTENDINGDATE);
			if( value != null)
			{
				AddChild( EtranscriptsDTD.ACTIVITYAWARD_INVOLVEMENTENDINGDATE, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;InvolvementAmount&gt;</c> element.
	/// </summary>
	/// <value> The <c>InvolvementAmount</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "An indication of the degree to which the individual is involved in the activity (e.g., number of hours per week)."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string InvolvementAmount
	{
		get
		{
			return (string) GetSifSimpleFieldValue( EtranscriptsDTD.ACTIVITYAWARD_INVOLVEMENTAMOUNT ) ;
		}
		set
		{
			SetFieldValue( EtranscriptsDTD.ACTIVITYAWARD_INVOLVEMENTAMOUNT, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;HonorsInformationCode&gt;</c> element.
	/// </summary>
	/// <value> The <c>HonorsInformationCode</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "A designation of the type of academic distinctions or other honors earned by or awarded to the student."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string HonorsInformationCode
	{
		get
		{ 
			return GetFieldValue( EtranscriptsDTD.ACTIVITYAWARD_HONORSINFORMATIONCODE );
		}
		set
		{
			SetField( EtranscriptsDTD.ACTIVITYAWARD_HONORSINFORMATIONCODE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;HonorsInformationCode&gt;</c> element.
	/// </summary>
	/// <param name="val">A HonorsInformationCode object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "A designation of the type of academic distinctions or other honors earned by or awarded to the student."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetHonorsInformationCode( HonorsInformationCode val )
	{
		SetField( EtranscriptsDTD.ACTIVITYAWARD_HONORSINFORMATIONCODE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;HonorsDescription&gt;</c> element.
	/// </summary>
	/// <value> The <c>HonorsDescription</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "A textual description of the distinction or honor."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string HonorsDescription
	{
		get
		{
			return (string) GetSifSimpleFieldValue( EtranscriptsDTD.ACTIVITYAWARD_HONORSDESCRIPTION ) ;
		}
		set
		{
			SetFieldValue( EtranscriptsDTD.ACTIVITYAWARD_HONORSDESCRIPTION, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;DiplomaCredentialHonorsCode&gt;</c> element.
	/// </summary>
	/// <value> The <c>DiplomaCredentialHonorsCode</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The nature of recognition given the student for the successful completion of work in high school."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string DiplomaCredentialHonorsCode
	{
		get
		{ 
			return GetFieldValue( EtranscriptsDTD.ACTIVITYAWARD_DIPLOMACREDENTIALHONORSCODE );
		}
		set
		{
			SetField( EtranscriptsDTD.ACTIVITYAWARD_DIPLOMACREDENTIALHONORSCODE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;DiplomaCredentialHonorsCode&gt;</c> element.
	/// </summary>
	/// <param name="val">A DiplomaCredentialAndHonorsType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The nature of recognition given the student for the successful completion of work in high school."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetDiplomaCredentialHonorsCode( DiplomaCredentialAndHonorsType val )
	{
		SetField( EtranscriptsDTD.ACTIVITYAWARD_DIPLOMACREDENTIALHONORSCODE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;DiplomaCredentialHonorsDescription&gt;</c> element.
	/// </summary>
	/// <value> The <c>DiplomaCredentialHonorsDescription</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "A textual description of the recognition."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string DiplomaCredentialHonorsDescription
	{
		get
		{
			return (string) GetSifSimpleFieldValue( EtranscriptsDTD.ACTIVITYAWARD_DIPLOMACREDENTIALHONORSDESCRIPTION ) ;
		}
		set
		{
			SetFieldValue( EtranscriptsDTD.ACTIVITYAWARD_DIPLOMACREDENTIALHONORSDESCRIPTION, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_ExtendedElements&gt;</c> element.
	/// </summary>
	/// <value> A SIF_ExtendedElements </value>
	/// <remarks>
	/// <para>To remove the <c>SIF_ExtendedElements</c>, set <c>SIF_ExtendedElements</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public SIF_ExtendedElements SIF_ExtendedElements
	{
		get
		{
			return (SIF_ExtendedElements)GetChild( EtranscriptsDTD.ACTIVITYAWARD_SIF_EXTENDEDELEMENTS);
		}
		set
		{
			RemoveChild( EtranscriptsDTD.ACTIVITYAWARD_SIF_EXTENDEDELEMENTS);
			if( value != null)
			{
				AddChild( EtranscriptsDTD.ACTIVITYAWARD_SIF_EXTENDEDELEMENTS, value );
			}
		}
	}

}}
