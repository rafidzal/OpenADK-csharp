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

namespace OpenADK.Library.au.Learning{

/// <summary>A StandardIdentifier</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.4</para>
/// </remarks>
[Serializable]
public class StandardIdentifier : SifElement
{
	/// <summary>
	/// Creates an instance of a StandardIdentifier
	/// </summary>
	public StandardIdentifier() : base ( LearningDTD.STANDARDIDENTIFIER ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="yearCreated">A YearCreated</param>
	///<param name="acStrandSubjectArea">An ACStrandSubjectArea</param>
	///<param name="standardNumber">A StandardNumber</param>
	///<param name="yearLevels">A YearLevels</param>
	///<param name="organization">An Organization</param>
	///
	public StandardIdentifier( Year yearCreated, ACStrandSubjectArea acStrandSubjectArea, string standardNumber, YearLevel yearLevels, string organization ) : base( LearningDTD.STANDARDIDENTIFIER )
	{
		this.YearCreated = yearCreated;
		this.ACStrandSubjectArea = acStrandSubjectArea;
		this.StandardNumber = standardNumber;
		this.YearLevels =  new YearLevels( yearLevels );
		this.Organization = organization;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected StandardIdentifier( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { LearningDTD.STANDARDIDENTIFIER_YEARCREATED, LearningDTD.STANDARDIDENTIFIER_ACSTRANDSUBJECTAREA, LearningDTD.STANDARDIDENTIFIER_STANDARDNUMBER, LearningDTD.STANDARDIDENTIFIER_YEARLEVELS, LearningDTD.STANDARDIDENTIFIER_ORGANIZATION }; }
	}

	///<summary>Sets the value of the <c>&lt;YearCreated&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;Year&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setYearCreated</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>YearCreated</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void SetYearCreated( int? Value ) {
		RemoveChild( LearningDTD.STANDARDIDENTIFIER_YEARCREATED);
		AddChild( LearningDTD.STANDARDIDENTIFIER_YEARCREATED, new Year( Value ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;YearCreated&gt;</c> element.
	/// </summary>
	/// <value> A Year </value>
	/// <remarks>
	/// <para>To remove the <c>Year</c>, set <c>YearCreated</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public Year YearCreated
	{
		get
		{
			return (Year)GetChild( LearningDTD.STANDARDIDENTIFIER_YEARCREATED);
		}
		set
		{
			RemoveChild( LearningDTD.STANDARDIDENTIFIER_YEARCREATED);
			if( value != null)
			{
				AddChild( LearningDTD.STANDARDIDENTIFIER_YEARCREATED, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;ACStrandSubjectArea&gt;</c> element.</summary>
	/// <param name="AcStrand">An ACStrand</param>
	///<remarks>
	/// <para>This form of <c>setACStrandSubjectArea</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>ACStrandSubjectArea</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void SetACStrandSubjectArea( AUCodeSetsACStrandType AcStrand ) {
		RemoveChild( LearningDTD.STANDARDIDENTIFIER_ACSTRANDSUBJECTAREA);
		AddChild( LearningDTD.STANDARDIDENTIFIER_ACSTRANDSUBJECTAREA, new ACStrandSubjectArea( AcStrand ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ACStrandSubjectArea&gt;</c> element.
	/// </summary>
	/// <value> An ACStrandSubjectArea </value>
	/// <remarks>
	/// <para>To remove the <c>ACStrandSubjectArea</c>, set <c>ACStrandSubjectArea</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public ACStrandSubjectArea ACStrandSubjectArea
	{
		get
		{
			return (ACStrandSubjectArea)GetChild( LearningDTD.STANDARDIDENTIFIER_ACSTRANDSUBJECTAREA);
		}
		set
		{
			RemoveChild( LearningDTD.STANDARDIDENTIFIER_ACSTRANDSUBJECTAREA);
			if( value != null)
			{
				AddChild( LearningDTD.STANDARDIDENTIFIER_ACSTRANDSUBJECTAREA, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;StandardNumber&gt;</c> element.
	/// </summary>
	/// <value> The <c>StandardNumber</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string StandardNumber
	{
		get
		{
			return (string) GetSifSimpleFieldValue( LearningDTD.STANDARDIDENTIFIER_STANDARDNUMBER ) ;
		}
		set
		{
			SetFieldValue( LearningDTD.STANDARDIDENTIFIER_STANDARDNUMBER, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;YearLevels&gt;</c> element.</summary>
	/// <param name="YearLevel">A YearLevel</param>
	///<remarks>
	/// <para>This form of <c>setYearLevels</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>YearLevels</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void SetYearLevels( YearLevel YearLevel ) {
		RemoveChild( LearningDTD.STANDARDIDENTIFIER_YEARLEVELS);
		AddChild( LearningDTD.STANDARDIDENTIFIER_YEARLEVELS, new YearLevels( YearLevel ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;YearLevels&gt;</c> element.
	/// </summary>
	/// <value> A YearLevels </value>
	/// <remarks>
	/// <para>To remove the <c>YearLevels</c>, set <c>YearLevels</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public YearLevels YearLevels
	{
		get
		{
			return (YearLevels)GetChild( LearningDTD.STANDARDIDENTIFIER_YEARLEVELS);
		}
		set
		{
			RemoveChild( LearningDTD.STANDARDIDENTIFIER_YEARLEVELS);
			if( value != null)
			{
				AddChild( LearningDTD.STANDARDIDENTIFIER_YEARLEVELS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Benchmark&gt;</c> element.
	/// </summary>
	/// <value> The <c>Benchmark</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string Benchmark
	{
		get
		{
			return (string) GetSifSimpleFieldValue( LearningDTD.STANDARDIDENTIFIER_BENCHMARK ) ;
		}
		set
		{
			SetFieldValue( LearningDTD.STANDARDIDENTIFIER_BENCHMARK, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;YearLevel&gt;</c> element.</summary>
	/// <param name="Code">Code representing the year level.</param>
	///<remarks>
	/// <para>This form of <c>setYearLevel</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>YearLevel</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void SetYearLevel( YearLevelCode Code ) {
		RemoveChild( LearningDTD.STANDARDIDENTIFIER_YEARLEVEL);
		AddChild( LearningDTD.STANDARDIDENTIFIER_YEARLEVEL, new YearLevel( Code ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;YearLevel&gt;</c> element.
	/// </summary>
	/// <value> A YearLevel </value>
	/// <remarks>
	/// <para>To remove the <c>YearLevel</c>, set <c>YearLevel</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public YearLevel YearLevel
	{
		get
		{
			return (YearLevel)GetChild( LearningDTD.STANDARDIDENTIFIER_YEARLEVEL);
		}
		set
		{
			RemoveChild( LearningDTD.STANDARDIDENTIFIER_YEARLEVEL);
			if( value != null)
			{
				AddChild( LearningDTD.STANDARDIDENTIFIER_YEARLEVEL, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;IndicatorNumber&gt;</c> element.
	/// </summary>
	/// <value> The <c>IndicatorNumber</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string IndicatorNumber
	{
		get
		{
			return (string) GetSifSimpleFieldValue( LearningDTD.STANDARDIDENTIFIER_INDICATORNUMBER ) ;
		}
		set
		{
			SetFieldValue( LearningDTD.STANDARDIDENTIFIER_INDICATORNUMBER, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;AlternateIdentificationCodes&gt;</c> element.</summary>
	/// <param name="AlternateIdentificationCode">An AlternateIdentificationCode</param>
	///<remarks>
	/// <para>This form of <c>setAlternateIdentificationCodes</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>AlternateIdentificationCodes</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void SetAlternateIdentificationCodes( AlternateIdentificationCode AlternateIdentificationCode ) {
		RemoveChild( LearningDTD.STANDARDIDENTIFIER_ALTERNATEIDENTIFICATIONCODES);
		AddChild( LearningDTD.STANDARDIDENTIFIER_ALTERNATEIDENTIFICATIONCODES, new AlternateIdentificationCodes( AlternateIdentificationCode ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AlternateIdentificationCodes&gt;</c> element.
	/// </summary>
	/// <value> An AlternateIdentificationCodes </value>
	/// <remarks>
	/// <para>To remove the <c>AlternateIdentificationCodes</c>, set <c>AlternateIdentificationCodes</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public AlternateIdentificationCodes AlternateIdentificationCodes
	{
		get
		{
			return (AlternateIdentificationCodes)GetChild( LearningDTD.STANDARDIDENTIFIER_ALTERNATEIDENTIFICATIONCODES);
		}
		set
		{
			RemoveChild( LearningDTD.STANDARDIDENTIFIER_ALTERNATEIDENTIFICATIONCODES);
			if( value != null)
			{
				AddChild( LearningDTD.STANDARDIDENTIFIER_ALTERNATEIDENTIFICATIONCODES, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Organization&gt;</c> element.
	/// </summary>
	/// <value> The <c>Organization</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string Organization
	{
		get
		{
			return (string) GetSifSimpleFieldValue( LearningDTD.STANDARDIDENTIFIER_ORGANIZATION ) ;
		}
		set
		{
			SetFieldValue( LearningDTD.STANDARDIDENTIFIER_ORGANIZATION, new SifString( value ), value );
		}
	}

}}
