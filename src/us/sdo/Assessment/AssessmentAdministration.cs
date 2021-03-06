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

namespace OpenADK.Library.us.Assessment{

/// <summary>This object represents an assessment event. It includes information related to the time of administration, place of administration, and unusual events related to the administration.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class AssessmentAdministration : SifDataObject
{
	/// <summary>
	/// Creates an instance of an AssessmentAdministration
	/// </summary>
	public AssessmentAdministration() : base( Adk.SifVersion, AssessmentDTD.ASSESSMENTADMINISTRATION ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">The GUID that uniquely identifies an instance of the object.</param>
	///<param name="assessmentFormRefId">The RefId of the assessment form used in the assessment administration.</param>
	///
	public AssessmentAdministration( string refId, string assessmentFormRefId ) : base( Adk.SifVersion, AssessmentDTD.ASSESSMENTADMINISTRATION )
	{
		this.RefId = refId;
		this.AssessmentFormRefId = assessmentFormRefId;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected AssessmentAdministration( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { AssessmentDTD.ASSESSMENTADMINISTRATION_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The GUID that uniquely identifies an instance of the object."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.ASSESSMENTADMINISTRATION_REFID ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ASSESSMENTADMINISTRATION_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>AssessmentFormRefId</c> attribute.
	/// </summary>
	/// <value> The <c>AssessmentFormRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The RefId of the assessment form used in the assessment administration."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string AssessmentFormRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.ASSESSMENTADMINISTRATION_ASSESSMENTFORMREFID ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ASSESSMENTADMINISTRATION_ASSESSMENTFORMREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AdministrationName&gt;</c> element.
	/// </summary>
	/// <value> The <c>AdministrationName</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string AdministrationName
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.ASSESSMENTADMINISTRATION_ADMINISTRATIONNAME ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ASSESSMENTADMINISTRATION_ADMINISTRATIONNAME, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SpecialConditions&gt;</c> element.
	/// </summary>
	/// <value> A SpecialConditions </value>
	/// <remarks>
	/// <para>To remove the <c>SpecialConditions</c>, set <c>SpecialConditions</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public SpecialConditions SpecialConditions
	{
		get
		{
			return (SpecialConditions)GetChild( AssessmentDTD.ASSESSMENTADMINISTRATION_SPECIALCONDITIONS);
		}
		set
		{
			RemoveChild( AssessmentDTD.ASSESSMENTADMINISTRATION_SPECIALCONDITIONS);
			if( value != null)
			{
				AddChild( AssessmentDTD.ASSESSMENTADMINISTRATION_SPECIALCONDITIONS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AdministrationDateTime&gt;</c> element.
	/// </summary>
	/// <value> The <c>AdministrationDateTime</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Date and time the test is scheduled to be given."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public DateTime? AdministrationDateTime
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( AssessmentDTD.ASSESSMENTADMINISTRATION_ADMINISTRATIONDATETIME ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ASSESSMENTADMINISTRATION_ADMINISTRATIONDATETIME, new SifDateTime( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;StartDateTime&gt;</c> element.
	/// </summary>
	/// <value> The <c>StartDateTime</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Date and time testing begins."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public DateTime? StartDateTime
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( AssessmentDTD.ASSESSMENTADMINISTRATION_STARTDATETIME ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ASSESSMENTADMINISTRATION_STARTDATETIME, new SifDateTime( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;FinishDateTime&gt;</c> element.
	/// </summary>
	/// <value> The <c>FinishDateTime</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Date and time testing ends."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public DateTime? FinishDateTime
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( AssessmentDTD.ASSESSMENTADMINISTRATION_FINISHDATETIME ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ASSESSMENTADMINISTRATION_FINISHDATETIME, new SifDateTime( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;DueDateTime&gt;</c> element.
	/// </summary>
	/// <value> The <c>DueDateTime</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Date and time test is due."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public DateTime? DueDateTime
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( AssessmentDTD.ASSESSMENTADMINISTRATION_DUEDATETIME ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ASSESSMENTADMINISTRATION_DUEDATETIME, new SifDateTime( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;Address&gt;</c> element.</summary>
	/// <param name="Type">Code that defines the location of the address.  Note:  A subset of specific valid values for each instance in a data object may be listed in that object.</param>
	/// <param name="Street">The street part of the address</param>
	/// <param name="City">The city part of the address.</param>
	/// <param name="StateProvince">The state or province code.</param>
	/// <param name="Country">The country code.</param>
	/// <param name="PostalCode">The ZIP/postal code.</param>
	///<remarks>
	/// <para>This form of <c>setAddress</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>Address</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetAddress( AddressType Type, Street Street, string City, StatePrCode StateProvince, CountryCode Country, string PostalCode ) {
		RemoveChild( AssessmentDTD.ASSESSMENTADMINISTRATION_ADDRESS);
		AddChild( AssessmentDTD.ASSESSMENTADMINISTRATION_ADDRESS, new Address( Type, Street, City, StateProvince, Country, PostalCode ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Address&gt;</c> element.
	/// </summary>
	/// <value> An Address </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Address of the location where the administration takes place."</para>
	/// <para>To remove the <c>Address</c>, set <c>Address</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public Address Address
	{
		get
		{
			return (Address)GetChild( AssessmentDTD.ASSESSMENTADMINISTRATION_ADDRESS);
		}
		set
		{
			RemoveChild( AssessmentDTD.ASSESSMENTADMINISTRATION_ADDRESS);
			if( value != null)
			{
				AddChild( AssessmentDTD.ASSESSMENTADMINISTRATION_ADDRESS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;StaffPersonalRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>StaffPersonalRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Optional reference to a staff person associated with the administration."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string StaffPersonalRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.ASSESSMENTADMINISTRATION_STAFFPERSONALREFID ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ASSESSMENTADMINISTRATION_STAFFPERSONALREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;LEAInfoRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>LEAInfoRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Optional reference to a school district associated with the administration."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string LEAInfoRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.ASSESSMENTADMINISTRATION_LEAINFOREFID ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ASSESSMENTADMINISTRATION_LEAINFOREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SchoolInfoRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>SchoolInfoRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Optional reference to a school associated with the administration."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string SchoolInfoRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.ASSESSMENTADMINISTRATION_SCHOOLINFOREFID ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ASSESSMENTADMINISTRATION_SCHOOLINFOREFID, new SifString( value ), value );
		}
	}

}}
