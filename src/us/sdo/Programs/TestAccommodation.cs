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

namespace OpenADK.Library.us.Programs{

/// <summary>A TestAccommodation</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class TestAccommodation : SifDataObject
{
	/// <summary>
	/// Creates an instance of a TestAccommodation
	/// </summary>
	public TestAccommodation() : base( Adk.SifVersion, ProgramsDTD.TESTACCOMMODATION ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">Unique ID for this set of test accommodations required for a particular student who is participating in a special program and for whom this set of test accommodation(s) is recommended / prescribed for this test administration (specific subject area and level) in a specific special programs plan.</param>
	///
	public TestAccommodation( string refId ) : base( Adk.SifVersion, ProgramsDTD.TESTACCOMMODATION )
	{
		this.RefId = refId;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected TestAccommodation( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { ProgramsDTD.TESTACCOMMODATION_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "Unique ID for this set of test accommodations required for a particular student who is participating in a special program and for whom this set of test accommodation(s) is recommended / prescribed for this test administration (specific subject area and level) in a specific special programs plan."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( ProgramsDTD.TESTACCOMMODATION_REFID ) ;
		}
		set
		{
			SetFieldValue( ProgramsDTD.TESTACCOMMODATION_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;StudentPersonalRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>StudentPersonalRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Reference to StudentPersonal object.  Typically a vendor is allowed to receive a StatePrId or a StudentName, but not both together.  The student must be identified by StudentPersonalRefId, or StudentName and LocalId, or StateStudentId."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string StudentPersonalRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( ProgramsDTD.TESTACCOMMODATION_STUDENTPERSONALREFID ) ;
		}
		set
		{
			SetFieldValue( ProgramsDTD.TESTACCOMMODATION_STUDENTPERSONALREFID, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;Name&gt;</c> element.</summary>
	/// <param name="Type">Code that specifies what type of name this is.  If unsure, use 04.</param>
	/// <param name="LastName">The last name.</param>
	/// <param name="FirstName">The first name.</param>
	///<remarks>
	/// <para>This form of <c>setName</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>Name</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetName( NameType Type, string LastName, string FirstName ) {
		RemoveChild( ProgramsDTD.TESTACCOMMODATION_NAME);
		AddChild( ProgramsDTD.TESTACCOMMODATION_NAME, new Name( Type, LastName, FirstName ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Name&gt;</c> element.
	/// </summary>
	/// <value> A Name </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "The student's name as presented in StudentPersonal object, Name element with a Type of 02 (Current Legal Name).  If Type 02 is not available, Type of 04 (Name of Record)"</para>
	/// <para>To remove the <c>Name</c>, set <c>Name</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public Name Name
	{
		get
		{
			return (Name)GetChild( ProgramsDTD.TESTACCOMMODATION_NAME);
		}
		set
		{
			RemoveChild( ProgramsDTD.TESTACCOMMODATION_NAME);
			if( value != null)
			{
				AddChild( ProgramsDTD.TESTACCOMMODATION_NAME, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;LocalId&gt;</c> element.
	/// </summary>
	/// <value> The <c>LocalId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The locally assigned identifier for this student."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string LocalId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( ProgramsDTD.TESTACCOMMODATION_LOCALID ) ;
		}
		set
		{
			SetFieldValue( ProgramsDTD.TESTACCOMMODATION_LOCALID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;StateProvinceId&gt;</c> element.
	/// </summary>
	/// <value> The <c>StateProvinceId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Reference to the state code identifying the student in the StudentPersonal object, as of the date of the response."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string StateProvinceId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( ProgramsDTD.TESTACCOMMODATION_STATEPROVINCEID ) ;
		}
		set
		{
			SetFieldValue( ProgramsDTD.TESTACCOMMODATION_STATEPROVINCEID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;StateDistrictId&gt;</c> element.
	/// </summary>
	/// <value> The <c>StateDistrictId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Reference to State code (StatePrId for LEAInfo) for the student's district of enrollment as of the date of the response (optional because school might be independent)."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string StateDistrictId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( ProgramsDTD.TESTACCOMMODATION_STATEDISTRICTID ) ;
		}
		set
		{
			SetFieldValue( ProgramsDTD.TESTACCOMMODATION_STATEDISTRICTID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;LEAInfoRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>LEAInfoRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The RefId for the district to which the student's home school of enrollment belongs as of the date of the response (optional because school might be independent)."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string LEAInfoRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( ProgramsDTD.TESTACCOMMODATION_LEAINFOREFID ) ;
		}
		set
		{
			SetFieldValue( ProgramsDTD.TESTACCOMMODATION_LEAINFOREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SchoolInfoRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>SchoolInfoRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The RefId for the student's home school of enrollment as of the date of the response."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string SchoolInfoRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( ProgramsDTD.TESTACCOMMODATION_SCHOOLINFOREFID ) ;
		}
		set
		{
			SetFieldValue( ProgramsDTD.TESTACCOMMODATION_SCHOOLINFOREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;StateSchoolId&gt;</c> element.
	/// </summary>
	/// <value> The <c>StateSchoolId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Reference to State code (StatePrId for SchoolInfo) for student's home school of enrollment as of the date of the response (optional because state may not require)."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string StateSchoolId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( ProgramsDTD.TESTACCOMMODATION_STATESCHOOLID ) ;
		}
		set
		{
			SetFieldValue( ProgramsDTD.TESTACCOMMODATION_STATESCHOOLID, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;GradeLevel&gt;</c> element.</summary>
	/// <param name="Code">Code representing the grade level.</param>
	///<remarks>
	/// <para>This form of <c>setGradeLevel</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>GradeLevel</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetGradeLevel( GradeLevelCode Code ) {
		RemoveChild( ProgramsDTD.TESTACCOMMODATION_GRADELEVEL);
		AddChild( ProgramsDTD.TESTACCOMMODATION_GRADELEVEL, new GradeLevel( Code ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;GradeLevel&gt;</c> element.
	/// </summary>
	/// <value> A GradeLevel </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Code for the current actual grade placement of the student as of the date of the response  from StudentSchoolEnrollment."</para>
	/// <para>To remove the <c>GradeLevel</c>, set <c>GradeLevel</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public GradeLevel GradeLevel
	{
		get
		{
			return (GradeLevel)GetChild( ProgramsDTD.TESTACCOMMODATION_GRADELEVEL);
		}
		set
		{
			RemoveChild( ProgramsDTD.TESTACCOMMODATION_GRADELEVEL);
			if( value != null)
			{
				AddChild( ProgramsDTD.TESTACCOMMODATION_GRADELEVEL, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssessmentRegistrationRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>AssessmentRegistrationRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "RefId for the student's registration / assignment to take a particular test (test name, subject area, level, grade level, type) at a particular time or within a particular timeframe.  An assessment may also be identified by omitting this element and specifying the whole set (TestAdministration, TestSubjectArea, TestGradeLevel, TestAdministrationDateRange or PlannedTestAdministrationDate, and TestType)."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string AssessmentRegistrationRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( ProgramsDTD.TESTACCOMMODATION_ASSESSMENTREGISTRATIONREFID ) ;
		}
		set
		{
			SetFieldValue( ProgramsDTD.TESTACCOMMODATION_ASSESSMENTREGISTRATIONREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;TestAdministration&gt;</c> element.
	/// </summary>
	/// <value> The <c>TestAdministration</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Abbreviated name of the test for which this set of accommodations is to be provided."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string TestAdministration
	{
		get
		{
			return (string) GetSifSimpleFieldValue( ProgramsDTD.TESTACCOMMODATION_TESTADMINISTRATION ) ;
		}
		set
		{
			SetFieldValue( ProgramsDTD.TESTACCOMMODATION_TESTADMINISTRATION, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;TestSubjectArea&gt;</c> element.
	/// </summary>
	/// <value> The <c>TestSubjectArea</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Subject area of the test.  Teachers may only supply this element, while a high-stakes test will supply the whole set (TestAdministration, TestSubjectArea, TestGradeLevel, TestAdministrationDateRange or PlannedTestAdministrationDate, and TestType)."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string TestSubjectArea
	{
		get
		{
			return (string) GetSifSimpleFieldValue( ProgramsDTD.TESTACCOMMODATION_TESTSUBJECTAREA ) ;
		}
		set
		{
			SetFieldValue( ProgramsDTD.TESTACCOMMODATION_TESTSUBJECTAREA, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;TestGradeLevel&gt;</c> element.
	/// </summary>
	/// <value> The <c>TestGradeLevel</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Grade level of the test."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string TestGradeLevel
	{
		get
		{
			return (string) GetSifSimpleFieldValue( ProgramsDTD.TESTACCOMMODATION_TESTGRADELEVEL ) ;
		}
		set
		{
			SetFieldValue( ProgramsDTD.TESTACCOMMODATION_TESTGRADELEVEL, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;TestAdministrationDateRange&gt;</c> element.
	/// </summary>
	/// <value> The <c>TestAdministrationDateRange</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "General date range of the test (e.g. "Spring 2005").  Date is identified by either TestAdministrationDateRange or PlannedTestAdministrationDate"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string TestAdministrationDateRange
	{
		get
		{
			return (string) GetSifSimpleFieldValue( ProgramsDTD.TESTACCOMMODATION_TESTADMINISTRATIONDATERANGE ) ;
		}
		set
		{
			SetFieldValue( ProgramsDTD.TESTACCOMMODATION_TESTADMINISTRATIONDATERANGE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;PlannedTestAdministrationDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>PlannedTestAdministrationDate</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The date the test is planned to be administered.  Should contain the most current known date (Date is needed in order to identify accommodations to be sent -- accommodations are date-dependent)."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public DateTime? PlannedTestAdministrationDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( ProgramsDTD.TESTACCOMMODATION_PLANNEDTESTADMINISTRATIONDATE ) ;
		}
		set
		{
			SetFieldValue( ProgramsDTD.TESTACCOMMODATION_PLANNEDTESTADMINISTRATIONDATE, new SifDate( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;TestType&gt;</c> element.
	/// </summary>
	/// <value> The <c>TestType</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Identifies whether the test the student is to take is a standard or alternate."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string TestType
	{
		get
		{ 
			return GetFieldValue( ProgramsDTD.TESTACCOMMODATION_TESTTYPE );
		}
		set
		{
			SetField( ProgramsDTD.TESTACCOMMODATION_TESTTYPE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;TestType&gt;</c> element.
	/// </summary>
	/// <param name="val">A TestType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Identifies whether the test the student is to take is a standard or alternate."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetTestType( TestType val )
	{
		SetField( ProgramsDTD.TESTACCOMMODATION_TESTTYPE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AuthorizedActual&gt;</c> element.
	/// </summary>
	/// <value> The <c>AuthorizedActual</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Indicator - Identifies whether accommodations in this object are authorized or were actually used."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string AuthorizedActual
	{
		get
		{ 
			return GetFieldValue( ProgramsDTD.TESTACCOMMODATION_AUTHORIZEDACTUAL );
		}
		set
		{
			SetField( ProgramsDTD.TESTACCOMMODATION_AUTHORIZEDACTUAL, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;AuthorizedActual&gt;</c> element.
	/// </summary>
	/// <param name="val">A AuthorizedActual object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Indicator - Identifies whether accommodations in this object are authorized or were actually used."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetAuthorizedActual( AuthorizedActual val )
	{
		SetField( ProgramsDTD.TESTACCOMMODATION_AUTHORIZEDACTUAL, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ActualTestAdministrationDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>ActualTestAdministrationDate</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The date the test was actually administered."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public DateTime? ActualTestAdministrationDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( ProgramsDTD.TESTACCOMMODATION_ACTUALTESTADMINISTRATIONDATE ) ;
		}
		set
		{
			SetFieldValue( ProgramsDTD.TESTACCOMMODATION_ACTUALTESTADMINISTRATIONDATE, new SifDate( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;StudentProgramAccommodations&gt;</c> element.
	/// </summary>
	/// <value> A StudentProgramAccommodations </value>
	/// <remarks>
	/// <para>To remove the <c>StudentProgramAccommodations</c>, set <c>StudentProgramAccommodations</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public StudentProgramAccommodations StudentProgramAccommodations
	{
		get
		{
			return (StudentProgramAccommodations)GetChild( ProgramsDTD.TESTACCOMMODATION_STUDENTPROGRAMACCOMMODATIONS);
		}
		set
		{
			RemoveChild( ProgramsDTD.TESTACCOMMODATION_STUDENTPROGRAMACCOMMODATIONS);
			if( value != null)
			{
				AddChild( ProgramsDTD.TESTACCOMMODATION_STUDENTPROGRAMACCOMMODATIONS, value );
			}
		}
	}

}}
