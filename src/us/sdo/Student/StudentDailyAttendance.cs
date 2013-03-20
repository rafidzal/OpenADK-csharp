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

/// <summary>This object provides daily attendance information for a particular student in a particular school on a particular date. SIF_Events are reported.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.1</para>
/// </remarks>
[Serializable]
public class StudentDailyAttendance : SifDataObject
{
	/// <summary>
	/// Creates an instance of a StudentDailyAttendance
	/// </summary>
	public StudentDailyAttendance() : base( Adk.SifVersion, StudentDTD.STUDENTDAILYATTENDANCE ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="studentPersonalRefId">The ID (GUID) of the student for whom this attendance information is being reported.</param>
	///<param name="schoolInfoRefId">The ID (GUID) of the school for which this attendance information is being reported.</param>
	///<param name="date">The calendar date to which this attendance information relates.</param>
	///<param name="schoolYear">
	///         School year for which this enrollment is applicable, expressed as the four-digit year in which the school year
	///         ends (e.g. 2007 for the 2006-07 school year).
	///       </param>
	///<param name="dailyAttendanceCode">Locally-defined attendance code information</param>
	///<param name="attendanceCodeInfoRefId">The ID (GUID) of the locally-defined daily attendance code information.</param>
	///
	public StudentDailyAttendance( string studentPersonalRefId, string schoolInfoRefId, DateTime? date, int? schoolYear, AttendanceCode dailyAttendanceCode, string attendanceCodeInfoRefId ) : base( Adk.SifVersion, StudentDTD.STUDENTDAILYATTENDANCE )
	{
		this.StudentPersonalRefId = studentPersonalRefId;
		this.SchoolInfoRefId = schoolInfoRefId;
		this.Date = date;
		this.SchoolYear = schoolYear;
		this.DailyAttendanceCode = dailyAttendanceCode;
		this.AttendanceCodeInfoRefId = attendanceCodeInfoRefId;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected StudentDailyAttendance( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { StudentDTD.STUDENTDAILYATTENDANCE_STUDENTPERSONALREFID, StudentDTD.STUDENTDAILYATTENDANCE_SCHOOLINFOREFID, StudentDTD.STUDENTDAILYATTENDANCE_DATE }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>StudentPersonalRefId</c> attribute.
	/// </summary>
	/// <value> The <c>StudentPersonalRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The ID (GUID) of the student for whom this attendance information is being reported."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public string StudentPersonalRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.STUDENTDAILYATTENDANCE_STUDENTPERSONALREFID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STUDENTDAILYATTENDANCE_STUDENTPERSONALREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>SchoolInfoRefId</c> attribute.
	/// </summary>
	/// <value> The <c>SchoolInfoRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The ID (GUID) of the school for which this attendance information is being reported."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public string SchoolInfoRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.STUDENTDAILYATTENDANCE_SCHOOLINFOREFID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STUDENTDAILYATTENDANCE_SCHOOLINFOREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>Date</c> attribute.
	/// </summary>
	/// <value> The <c>Date</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The calendar date to which this attendance information relates."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public DateTime? Date
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( StudentDTD.STUDENTDAILYATTENDANCE_DATE ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STUDENTDAILYATTENDANCE_DATE, new SifDate( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>SchoolYear</c> attribute.
	/// </summary>
	/// <value> The <c>SchoolYear</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "
	///         School year for which this enrollment is applicable, expressed as the four-digit year in which the school year
	///         ends (e.g. 2007 for the 2006-07 school year).
	///       "</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public int? SchoolYear
	{
		get
		{
			return (int?) GetSifSimpleFieldValue( StudentDTD.STUDENTDAILYATTENDANCE_SCHOOLYEAR ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STUDENTDAILYATTENDANCE_SCHOOLYEAR, new SifInt( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;DailyAttendanceCode&gt;</c> element.</summary>
	/// <param name="AttendanceCodeInfoRefId">The ID (GUID) of the attendance code</param>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;AttendanceCode&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setDailyAttendanceCode</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>DailyAttendanceCode</c></para>
	/// <para>Version: 1.5r1</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public void SetDailyAttendanceCode( string AttendanceCodeInfoRefId, string Value ) {
		RemoveChild( StudentDTD.STUDENTDAILYATTENDANCE_DAILYATTENDANCECODE);
		AddChild( StudentDTD.STUDENTDAILYATTENDANCE_DAILYATTENDANCECODE, new AttendanceCode( AttendanceCodeInfoRefId, Value ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;DailyAttendanceCode&gt;</c> element.
	/// </summary>
	/// <value> An AttendanceCode </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Locally-defined attendance code information"</para>
	/// <para>To remove the <c>AttendanceCode</c>, set <c>DailyAttendanceCode</c> to <c>null</c></para>
	/// <para>Version: 1.5r1</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public AttendanceCode DailyAttendanceCode
	{
		get
		{
			return (AttendanceCode)GetChild( StudentDTD.STUDENTDAILYATTENDANCE_DAILYATTENDANCECODE);
		}
		set
		{
			RemoveChild( StudentDTD.STUDENTDAILYATTENDANCE_DAILYATTENDANCECODE);
			if( value != null)
			{
				AddChild( StudentDTD.STUDENTDAILYATTENDANCE_DAILYATTENDANCECODE, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;TimeIn&gt;</c> element.
	/// </summary>
	/// <value> The <c>TimeIn</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The time the student entered or returned to school."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public DateTime? TimeIn
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( StudentDTD.STUDENTDAILYATTENDANCE_TIMEIN ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STUDENTDAILYATTENDANCE_TIMEIN, new SifTime( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AttendanceCodeInfoRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>AttendanceCodeInfoRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The ID (GUID) of the locally-defined daily attendance code information."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string AttendanceCodeInfoRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.STUDENTDAILYATTENDANCE_ATTENDANCECODEINFOREFID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STUDENTDAILYATTENDANCE_ATTENDANCECODEINFOREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;TimeOut&gt;</c> element.
	/// </summary>
	/// <value> The <c>TimeOut</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The time the student left school."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public DateTime? TimeOut
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( StudentDTD.STUDENTDAILYATTENDANCE_TIMEOUT ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STUDENTDAILYATTENDANCE_TIMEOUT, new SifTime( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AttendanceNote&gt;</c> element.
	/// </summary>
	/// <value> The <c>AttendanceNote</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Note related to this particular attendance."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public string AttendanceNote
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.STUDENTDAILYATTENDANCE_ATTENDANCENOTE ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STUDENTDAILYATTENDANCE_ATTENDANCENOTE, new SifString( value ), value );
		}
	}

}}
