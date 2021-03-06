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

/// <summary>An AcademicPerformanceSummary</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class AcademicPerformanceSummary : SifElement
{
	/// <summary>
	/// Creates an instance of an AcademicPerformanceSummary
	/// </summary>
	public AcademicPerformanceSummary() : base ( EtranscriptsDTD.ACADEMICPERFORMANCESUMMARY ){}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected AcademicPerformanceSummary( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets or sets the value of the <c>&lt;TotalCreditsAttempted&gt;</c> element.
	/// </summary>
	/// <value> The <c>TotalCreditsAttempted</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Total credits attempted during academic career."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public decimal? TotalCreditsAttempted
	{
		get
		{
			return (decimal?) GetSifSimpleFieldValue( EtranscriptsDTD.ACADEMICPERFORMANCESUMMARY_TOTALCREDITSATTEMPTED ) ;
		}
		set
		{
			SetFieldValue( EtranscriptsDTD.ACADEMICPERFORMANCESUMMARY_TOTALCREDITSATTEMPTED, new SifDecimal( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;TotalCreditsEarned&gt;</c> element.
	/// </summary>
	/// <value> The <c>TotalCreditsEarned</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Total credits earned during academic career."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public decimal? TotalCreditsEarned
	{
		get
		{
			return (decimal?) GetSifSimpleFieldValue( EtranscriptsDTD.ACADEMICPERFORMANCESUMMARY_TOTALCREDITSEARNED ) ;
		}
		set
		{
			SetFieldValue( EtranscriptsDTD.ACADEMICPERFORMANCESUMMARY_TOTALCREDITSEARNED, new SifDecimal( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;CumulativeGPACreditsEarned&gt;</c> element.
	/// </summary>
	/// <value> The <c>CumulativeGPACreditsEarned</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Cumulative number of GPA credits earned during academic career."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public decimal? CumulativeGPACreditsEarned
	{
		get
		{
			return (decimal?) GetSifSimpleFieldValue( EtranscriptsDTD.ACADEMICPERFORMANCESUMMARY_CUMULATIVEGPACREDITSEARNED ) ;
		}
		set
		{
			SetFieldValue( EtranscriptsDTD.ACADEMICPERFORMANCESUMMARY_CUMULATIVEGPACREDITSEARNED, new SifDecimal( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;CumulativeGradePoints&gt;</c> element.
	/// </summary>
	/// <value> The <c>CumulativeGradePoints</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Cumulative number of grade points earned during academic career."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public decimal? CumulativeGradePoints
	{
		get
		{
			return (decimal?) GetSifSimpleFieldValue( EtranscriptsDTD.ACADEMICPERFORMANCESUMMARY_CUMULATIVEGRADEPOINTS ) ;
		}
		set
		{
			SetFieldValue( EtranscriptsDTD.ACADEMICPERFORMANCESUMMARY_CUMULATIVEGRADEPOINTS, new SifDecimal( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;CumulativeGPA&gt;</c> element.
	/// </summary>
	/// <value> The <c>CumulativeGPA</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Cumulative grade point average for academic career."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public decimal? CumulativeGPA
	{
		get
		{
			return (decimal?) GetSifSimpleFieldValue( EtranscriptsDTD.ACADEMICPERFORMANCESUMMARY_CUMULATIVEGPA ) ;
		}
		set
		{
			SetFieldValue( EtranscriptsDTD.ACADEMICPERFORMANCESUMMARY_CUMULATIVEGPA, new SifDecimal( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;GPAType&gt;</c> element.
	/// </summary>
	/// <value> The <c>GPAType</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Brief name/description of type of GPA."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string GPAType
	{
		get
		{
			return (string) GetSifSimpleFieldValue( EtranscriptsDTD.ACADEMICPERFORMANCESUMMARY_GPATYPE ) ;
		}
		set
		{
			SetFieldValue( EtranscriptsDTD.ACADEMICPERFORMANCESUMMARY_GPATYPE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ClassRank&gt;</c> element.
	/// </summary>
	/// <value> The <c>ClassRank</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Student's rank in graduating class."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public int? ClassRank
	{
		get
		{
			return (int?) GetSifSimpleFieldValue( EtranscriptsDTD.ACADEMICPERFORMANCESUMMARY_CLASSRANK ) ;
		}
		set
		{
			SetFieldValue( EtranscriptsDTD.ACADEMICPERFORMANCESUMMARY_CLASSRANK, new SifInt( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ClassTotalNumber&gt;</c> element.
	/// </summary>
	/// <value> The <c>ClassTotalNumber</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Total number of students in student's graduating class."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public int? ClassTotalNumber
	{
		get
		{
			return (int?) GetSifSimpleFieldValue( EtranscriptsDTD.ACADEMICPERFORMANCESUMMARY_CLASSTOTALNUMBER ) ;
		}
		set
		{
			SetFieldValue( EtranscriptsDTD.ACADEMICPERFORMANCESUMMARY_CLASSTOTALNUMBER, new SifInt( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;ClassRankingDate&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;PartialDateType&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setClassRankingDate</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>ClassRankingDate</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetClassRankingDate( string Value ) {
		RemoveChild( EtranscriptsDTD.ACADEMICPERFORMANCESUMMARY_CLASSRANKINGDATE);
		AddChild( EtranscriptsDTD.ACADEMICPERFORMANCESUMMARY_CLASSRANKINGDATE, new PartialDateType( Value ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ClassRankingDate&gt;</c> element.
	/// </summary>
	/// <value> A PartialDateType </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Date class ranking was determined."</para>
	/// <para>To remove the <c>PartialDateType</c>, set <c>ClassRankingDate</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public PartialDateType ClassRankingDate
	{
		get
		{
			return (PartialDateType)GetChild( EtranscriptsDTD.ACADEMICPERFORMANCESUMMARY_CLASSRANKINGDATE);
		}
		set
		{
			RemoveChild( EtranscriptsDTD.ACADEMICPERFORMANCESUMMARY_CLASSRANKINGDATE);
			if( value != null)
			{
				AddChild( EtranscriptsDTD.ACADEMICPERFORMANCESUMMARY_CLASSRANKINGDATE, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;ProjectedGraduationDate&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;PartialDateType&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setProjectedGraduationDate</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>ProjectedGraduationDate</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetProjectedGraduationDate( string Value ) {
		RemoveChild( EtranscriptsDTD.ACADEMICPERFORMANCESUMMARY_PROJECTEDGRADUATIONDATE);
		AddChild( EtranscriptsDTD.ACADEMICPERFORMANCESUMMARY_PROJECTEDGRADUATIONDATE, new PartialDateType( Value ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ProjectedGraduationDate&gt;</c> element.
	/// </summary>
	/// <value> A PartialDateType </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Projected graduation date."</para>
	/// <para>To remove the <c>PartialDateType</c>, set <c>ProjectedGraduationDate</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public PartialDateType ProjectedGraduationDate
	{
		get
		{
			return (PartialDateType)GetChild( EtranscriptsDTD.ACADEMICPERFORMANCESUMMARY_PROJECTEDGRADUATIONDATE);
		}
		set
		{
			RemoveChild( EtranscriptsDTD.ACADEMICPERFORMANCESUMMARY_PROJECTEDGRADUATIONDATE);
			if( value != null)
			{
				AddChild( EtranscriptsDTD.ACADEMICPERFORMANCESUMMARY_PROJECTEDGRADUATIONDATE, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;GraduationDate&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;PartialDateType&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setGraduationDate</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>GraduationDate</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetGraduationDate( string Value ) {
		RemoveChild( EtranscriptsDTD.ACADEMICPERFORMANCESUMMARY_GRADUATIONDATE);
		AddChild( EtranscriptsDTD.ACADEMICPERFORMANCESUMMARY_GRADUATIONDATE, new PartialDateType( Value ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;GraduationDate&gt;</c> element.
	/// </summary>
	/// <value> A PartialDateType </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Note: Mandatory if graduated.  Graduation date."</para>
	/// <para>To remove the <c>PartialDateType</c>, set <c>GraduationDate</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public PartialDateType GraduationDate
	{
		get
		{
			return (PartialDateType)GetChild( EtranscriptsDTD.ACADEMICPERFORMANCESUMMARY_GRADUATIONDATE);
		}
		set
		{
			RemoveChild( EtranscriptsDTD.ACADEMICPERFORMANCESUMMARY_GRADUATIONDATE);
			if( value != null)
			{
				AddChild( EtranscriptsDTD.ACADEMICPERFORMANCESUMMARY_GRADUATIONDATE, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;GraduationDiplomaType&gt;</c> element.
	/// </summary>
	/// <value> The <c>GraduationDiplomaType</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Note: Mandatory if graduated.  Type of diploma earned."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string GraduationDiplomaType
	{
		get
		{
			return (string) GetSifSimpleFieldValue( EtranscriptsDTD.ACADEMICPERFORMANCESUMMARY_GRADUATIONDIPLOMATYPE ) ;
		}
		set
		{
			SetFieldValue( EtranscriptsDTD.ACADEMICPERFORMANCESUMMARY_GRADUATIONDIPLOMATYPE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AcademicTrack&gt;</c> element.
	/// </summary>
	/// <value> The <c>AcademicTrack</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "An indication of the general nature and difficulty of instruction provided throughout a course."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string AcademicTrack
	{
		get
		{ 
			return GetFieldValue( EtranscriptsDTD.ACADEMICPERFORMANCESUMMARY_ACADEMICTRACK );
		}
		set
		{
			SetField( EtranscriptsDTD.ACADEMICPERFORMANCESUMMARY_ACADEMICTRACK, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;AcademicTrack&gt;</c> element.
	/// </summary>
	/// <param name="val">A InstructionalLevelCode object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "An indication of the general nature and difficulty of instruction provided throughout a course."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetAcademicTrack( InstructionalLevelCode val )
	{
		SetField( EtranscriptsDTD.ACADEMICPERFORMANCESUMMARY_ACADEMICTRACK, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AcademicFoci&gt;</c> element.
	/// </summary>
	/// <value> An AcademicFoci </value>
	/// <remarks>
	/// <para>To remove the <c>AcademicFoci</c>, set <c>AcademicFoci</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.2</para>
	/// </remarks>
	public AcademicFoci AcademicFoci
	{
		get
		{
			return (AcademicFoci)GetChild( EtranscriptsDTD.ACADEMICPERFORMANCESUMMARY_ACADEMICFOCI);
		}
		set
		{
			RemoveChild( EtranscriptsDTD.ACADEMICPERFORMANCESUMMARY_ACADEMICFOCI);
			if( value != null)
			{
				AddChild( EtranscriptsDTD.ACADEMICPERFORMANCESUMMARY_ACADEMICFOCI, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AcademicSubjects&gt;</c> element.
	/// </summary>
	/// <value> An AcademicSubjects </value>
	/// <remarks>
	/// <para>To remove the <c>AcademicSubjects</c>, set <c>AcademicSubjects</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.2</para>
	/// </remarks>
	public AcademicSubjects AcademicSubjects
	{
		get
		{
			return (AcademicSubjects)GetChild( EtranscriptsDTD.ACADEMICPERFORMANCESUMMARY_ACADEMICSUBJECTS);
		}
		set
		{
			RemoveChild( EtranscriptsDTD.ACADEMICPERFORMANCESUMMARY_ACADEMICSUBJECTS);
			if( value != null)
			{
				AddChild( EtranscriptsDTD.ACADEMICPERFORMANCESUMMARY_ACADEMICSUBJECTS, value );
			}
		}
	}

}}
