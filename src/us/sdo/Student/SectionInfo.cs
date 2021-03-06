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

/// <summary>This object provides information about the section - the specific time period a session of the course meets</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.1</para>
/// </remarks>
[Serializable]
public class SectionInfo : SifDataObject
{
	/// <summary>
	/// Creates an instance of a SectionInfo
	/// </summary>
	public SectionInfo() : base( Adk.SifVersion, StudentDTD.SECTIONINFO ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">The ID (GUID) that uniquely identifies this section entity.</param>
	///<param name="schoolCourseInfoRefId">The ID (GUID) that identifies the course being taught in this section.</param>
	///<param name="schoolYear">School year for which the information is applicable, expressed as the four-digit year in which the school year ends (e.g. 2007 for the 2006-07 school year).</param>
	///<param name="scheduleInfoList">The schedule-related information for a section</param>
	///
	public SectionInfo( string refId, string schoolCourseInfoRefId, int? schoolYear, ScheduleInfoList scheduleInfoList ) : base( Adk.SifVersion, StudentDTD.SECTIONINFO )
	{
		this.RefId = refId;
		this.SchoolCourseInfoRefId = schoolCourseInfoRefId;
		this.SchoolYear = schoolYear;
		this.ScheduleInfoList = scheduleInfoList;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected SectionInfo( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { StudentDTD.SECTIONINFO_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The ID (GUID) that uniquely identifies this section entity."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.SECTIONINFO_REFID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.SECTIONINFO_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>SchoolCourseInfoRefId</c> attribute.
	/// </summary>
	/// <value> The <c>SchoolCourseInfoRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The ID (GUID) that identifies the course being taught in this section."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public string SchoolCourseInfoRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.SECTIONINFO_SCHOOLCOURSEINFOREFID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.SECTIONINFO_SCHOOLCOURSEINFOREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>SchoolYear</c> attribute.
	/// </summary>
	/// <value> The <c>SchoolYear</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "School year for which the information is applicable, expressed as the four-digit year in which the school year ends (e.g. 2007 for the 2006-07 school year)."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public int? SchoolYear
	{
		get
		{
			return (int?) GetSifSimpleFieldValue( StudentDTD.SECTIONINFO_SCHOOLYEAR ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.SECTIONINFO_SCHOOLYEAR, new SifInt( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ScheduleInfoList&gt;</c> element.
	/// </summary>
	/// <value> A ScheduleInfoList </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "The schedule-related information for a section"</para>
	/// <para>To remove the <c>ScheduleInfoList</c>, set <c>ScheduleInfoList</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public ScheduleInfoList ScheduleInfoList
	{
		get
		{
			return (ScheduleInfoList)GetChild( StudentDTD.SECTIONINFO_SCHEDULEINFOLIST);
		}
		set
		{
			RemoveChild( StudentDTD.SECTIONINFO_SCHEDULEINFOLIST);
			if( value != null)
			{
				AddChild( StudentDTD.SECTIONINFO_SCHEDULEINFOLIST, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;MediumOfInstruction&gt;</c> element.</summary>
	/// <param name="Code">Code representing the medium of instruction.</param>
	///<remarks>
	/// <para>This form of <c>setMediumOfInstruction</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>MediumOfInstruction</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public void SetMediumOfInstruction( MediumOfInstructionCode Code ) {
		RemoveChild( StudentDTD.SECTIONINFO_MEDIUMOFINSTRUCTION);
		AddChild( StudentDTD.SECTIONINFO_MEDIUMOFINSTRUCTION, new MediumOfInstruction( Code ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;MediumOfInstruction&gt;</c> element.
	/// </summary>
	/// <value> A MediumOfInstruction </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Medium through which the student receives instructional communication from the teacher"</para>
	/// <para>To remove the <c>MediumOfInstruction</c>, set <c>MediumOfInstruction</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public MediumOfInstruction MediumOfInstruction
	{
		get
		{
			return (MediumOfInstruction)GetChild( StudentDTD.SECTIONINFO_MEDIUMOFINSTRUCTION);
		}
		set
		{
			RemoveChild( StudentDTD.SECTIONINFO_MEDIUMOFINSTRUCTION);
			if( value != null)
			{
				AddChild( StudentDTD.SECTIONINFO_MEDIUMOFINSTRUCTION, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;LocalId&gt;</c> element.
	/// </summary>
	/// <value> The <c>LocalId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The locally-assigned identifier for this course section."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string LocalId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.SECTIONINFO_LOCALID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.SECTIONINFO_LOCALID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Description&gt;</c> element.
	/// </summary>
	/// <value> The <c>Description</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Description of the course section."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string Description
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.SECTIONINFO_DESCRIPTION ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.SECTIONINFO_DESCRIPTION, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;LanguageOfInstruction&gt;</c> element.
	/// </summary>
	/// <value> A LanguageOfInstruction </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Language in which the section is taught"</para>
	/// <para>To remove the <c>LanguageOfInstruction</c>, set <c>LanguageOfInstruction</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public LanguageOfInstruction LanguageOfInstruction
	{
		get
		{
			return (LanguageOfInstruction)GetChild( StudentDTD.SECTIONINFO_LANGUAGEOFINSTRUCTION);
		}
		set
		{
			RemoveChild( StudentDTD.SECTIONINFO_LANGUAGEOFINSTRUCTION);
			if( value != null)
			{
				AddChild( StudentDTD.SECTIONINFO_LANGUAGEOFINSTRUCTION, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;LocationOfInstruction&gt;</c> element.</summary>
	/// <param name="Code">Code representing the location of instruction.</param>
	///<remarks>
	/// <para>This form of <c>setLocationOfInstruction</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>LocationOfInstruction</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public void SetLocationOfInstruction( LocationOfInstructionCode Code ) {
		RemoveChild( StudentDTD.SECTIONINFO_LOCATIONOFINSTRUCTION);
		AddChild( StudentDTD.SECTIONINFO_LOCATIONOFINSTRUCTION, new LocationOfInstruction( Code ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;LocationOfInstruction&gt;</c> element.
	/// </summary>
	/// <value> A LocationOfInstruction </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Description of the location in which the section is taught"</para>
	/// <para>To remove the <c>LocationOfInstruction</c>, set <c>LocationOfInstruction</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public LocationOfInstruction LocationOfInstruction
	{
		get
		{
			return (LocationOfInstruction)GetChild( StudentDTD.SECTIONINFO_LOCATIONOFINSTRUCTION);
		}
		set
		{
			RemoveChild( StudentDTD.SECTIONINFO_LOCATIONOFINSTRUCTION);
			if( value != null)
			{
				AddChild( StudentDTD.SECTIONINFO_LOCATIONOFINSTRUCTION, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;SchoolCourseInfoOverride&gt;</c> element.</summary>
	/// <param name="Override">Designates whether or not SchoolCourseInfo information has been overridden with different values for this section</param>
	///<remarks>
	/// <para>This form of <c>setSchoolCourseInfoOverride</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>SchoolCourseInfoOverride</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public void SetSchoolCourseInfoOverride( YesNo Override ) {
		RemoveChild( StudentDTD.SECTIONINFO_SCHOOLCOURSEINFOOVERRIDE);
		AddChild( StudentDTD.SECTIONINFO_SCHOOLCOURSEINFOOVERRIDE, new SchoolCourseInfoOverride( Override ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SchoolCourseInfoOverride&gt;</c> element.
	/// </summary>
	/// <value> A SchoolCourseInfoOverride </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Optional overrides of the course information for this section"</para>
	/// <para>To remove the <c>SchoolCourseInfoOverride</c>, set <c>SchoolCourseInfoOverride</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public SchoolCourseInfoOverride SchoolCourseInfoOverride
	{
		get
		{
			return (SchoolCourseInfoOverride)GetChild( StudentDTD.SECTIONINFO_SCHOOLCOURSEINFOOVERRIDE);
		}
		set
		{
			RemoveChild( StudentDTD.SECTIONINFO_SCHOOLCOURSEINFOOVERRIDE);
			if( value != null)
			{
				AddChild( StudentDTD.SECTIONINFO_SCHOOLCOURSEINFOOVERRIDE, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SummerSchool&gt;</c> element.
	/// </summary>
	/// <value> The <c>SummerSchool</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Is this a summer school assignment?"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string SummerSchool
	{
		get
		{ 
			return GetFieldValue( StudentDTD.SECTIONINFO_SUMMERSCHOOL );
		}
		set
		{
			SetField( StudentDTD.SECTIONINFO_SUMMERSCHOOL, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;SummerSchool&gt;</c> element.
	/// </summary>
	/// <param name="val">A YesNo object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Is this a summer school assignment?"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetSummerSchool( YesNo val )
	{
		SetField( StudentDTD.SECTIONINFO_SUMMERSCHOOL, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;CourseSectionCode&gt;</c> element.
	/// </summary>
	/// <value> The <c>CourseSectionCode</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "A section code that is linked to a course. This should be a unique identifier within the school year and course (i.e. the class instance number for a course). For example, Algebra I: Section 23 is different from English II: Section 23."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string CourseSectionCode
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.SECTIONINFO_COURSESECTIONCODE ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.SECTIONINFO_COURSESECTIONCODE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SectionCode&gt;</c> element.
	/// </summary>
	/// <value> The <c>SectionCode</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "A unique identifier of the section for the school year and across courses (i.e. unique across all courses). For example, Algebra I sections range from 00122 to 00140 and English II courses range from 00141 to 00152."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string SectionCode
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.SECTIONINFO_SECTIONCODE ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.SECTIONINFO_SECTIONCODE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;CountForAttendance&gt;</c> element.
	/// </summary>
	/// <value> The <c>CountForAttendance</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Indicates if attendance in this section is collected and used in attendance calculations."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string CountForAttendance
	{
		get
		{ 
			return GetFieldValue( StudentDTD.SECTIONINFO_COUNTFORATTENDANCE );
		}
		set
		{
			SetField( StudentDTD.SECTIONINFO_COUNTFORATTENDANCE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;CountForAttendance&gt;</c> element.
	/// </summary>
	/// <param name="val">A YesNo object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Indicates if attendance in this section is collected and used in attendance calculations."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void SetCountForAttendance( YesNo val )
	{
		SetField( StudentDTD.SECTIONINFO_COUNTFORATTENDANCE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;BellScheduleRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>BellScheduleRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The GUID of the bell schedule used by this section."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string BellScheduleRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.SECTIONINFO_BELLSCHEDULEREFID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.SECTIONINFO_BELLSCHEDULEREFID, new SifString( value ), value );
		}
	}

}}
