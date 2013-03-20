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

/// <summary>A Sif3AssessmentRubric</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.6</para>
/// </remarks>
[Serializable]
public class Sif3AssessmentRubric : SifDataObject
{
	/// <summary>
	/// Creates an instance of a Sif3AssessmentRubric
	/// </summary>
	public Sif3AssessmentRubric() : base( Adk.SifVersion, Sif3assessmentDTD.SIF3ASSESSMENTRUBRIC ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">A RefId</param>
	///<param name="rubricName">A RubricName</param>
	///
	public Sif3AssessmentRubric( string refId, string rubricName ) : base( Adk.SifVersion, Sif3assessmentDTD.SIF3ASSESSMENTRUBRIC )
	{
		this.RefId = refId;
		this.RubricName = rubricName;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Sif3AssessmentRubric( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { Sif3assessmentDTD.SIF3ASSESSMENTRUBRIC_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( Sif3assessmentDTD.SIF3ASSESSMENTRUBRIC_REFID ) ;
		}
		set
		{
			SetFieldValue( Sif3assessmentDTD.SIF3ASSESSMENTRUBRIC_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;RubricVersion&gt;</c> element.
	/// </summary>
	/// <value> The <c>RubricVersion</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string RubricVersion
	{
		get
		{
			return (string) GetSifSimpleFieldValue( Sif3assessmentDTD.SIF3ASSESSMENTRUBRIC_RUBRICVERSION ) ;
		}
		set
		{
			SetFieldValue( Sif3assessmentDTD.SIF3ASSESSMENTRUBRIC_RUBRICVERSION, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;RubricPublishDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>RubricPublishDate</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public DateTime? RubricPublishDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( Sif3assessmentDTD.SIF3ASSESSMENTRUBRIC_RUBRICPUBLISHDATE ) ;
		}
		set
		{
			SetFieldValue( Sif3assessmentDTD.SIF3ASSESSMENTRUBRIC_RUBRICPUBLISHDATE, new SifDateTime( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;RubricIdentifiers&gt;</c> element.</summary>
	/// <param name="RubricIdentifier">A RubricIdentifier</param>
	///<remarks>
	/// <para>This form of <c>setRubricIdentifiers</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>RubricIdentifiers</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetRubricIdentifiers( RubricIdentifier RubricIdentifier ) {
		RemoveChild( Sif3assessmentDTD.SIF3ASSESSMENTRUBRIC_RUBRICIDENTIFIERS);
		AddChild( Sif3assessmentDTD.SIF3ASSESSMENTRUBRIC_RUBRICIDENTIFIERS, new RubricIdentifiers( RubricIdentifier ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;RubricIdentifiers&gt;</c> element.
	/// </summary>
	/// <value> A RubricIdentifiers </value>
	/// <remarks>
	/// <para>To remove the <c>RubricIdentifiers</c>, set <c>RubricIdentifiers</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public RubricIdentifiers RubricIdentifiers
	{
		get
		{
			return (RubricIdentifiers)GetChild( Sif3assessmentDTD.SIF3ASSESSMENTRUBRIC_RUBRICIDENTIFIERS);
		}
		set
		{
			RemoveChild( Sif3assessmentDTD.SIF3ASSESSMENTRUBRIC_RUBRICIDENTIFIERS);
			if( value != null)
			{
				AddChild( Sif3assessmentDTD.SIF3ASSESSMENTRUBRIC_RUBRICIDENTIFIERS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;RubricName&gt;</c> element.
	/// </summary>
	/// <value> The <c>RubricName</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string RubricName
	{
		get
		{
			return (string) GetSifSimpleFieldValue( Sif3assessmentDTD.SIF3ASSESSMENTRUBRIC_RUBRICNAME ) ;
		}
		set
		{
			SetFieldValue( Sif3assessmentDTD.SIF3ASSESSMENTRUBRIC_RUBRICNAME, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ScoringGuideReference&gt;</c> element.
	/// </summary>
	/// <value> The <c>ScoringGuideReference</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string ScoringGuideReference
	{
		get
		{
			return (string) GetSifSimpleFieldValue( Sif3assessmentDTD.SIF3ASSESSMENTRUBRIC_SCORINGGUIDEREFERENCE ) ;
		}
		set
		{
			SetFieldValue( Sif3assessmentDTD.SIF3ASSESSMENTRUBRIC_SCORINGGUIDEREFERENCE, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;Scores&gt;</c> element.</summary>
	/// <param name="Score">A Score</param>
	///<remarks>
	/// <para>This form of <c>setScores</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>Scores</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetScores( Sif3Score Score ) {
		RemoveChild( Sif3assessmentDTD.SIF3ASSESSMENTRUBRIC_SCORES);
		AddChild( Sif3assessmentDTD.SIF3ASSESSMENTRUBRIC_SCORES, new ScoreList( Score ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Scores&gt;</c> element.
	/// </summary>
	/// <value> A ScoreList </value>
	/// <remarks>
	/// <para>To remove the <c>ScoreList</c>, set <c>Scores</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public ScoreList Scores
	{
		get
		{
			return (ScoreList)GetChild( Sif3assessmentDTD.SIF3ASSESSMENTRUBRIC_SCORES);
		}
		set
		{
			RemoveChild( Sif3assessmentDTD.SIF3ASSESSMENTRUBRIC_SCORES);
			if( value != null)
			{
				AddChild( Sif3assessmentDTD.SIF3ASSESSMENTRUBRIC_SCORES, value );
			}
		}
	}

}}