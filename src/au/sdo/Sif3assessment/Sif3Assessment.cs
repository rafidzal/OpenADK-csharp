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

/// <summary>A Sif3Assessment</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.6</para>
/// </remarks>
[Serializable]
public class Sif3Assessment : SifDataObject
{
	/// <summary>
	/// Creates an instance of a Sif3Assessment
	/// </summary>
	public Sif3Assessment() : base( Adk.SifVersion, Sif3assessmentDTD.SIF3ASSESSMENT ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">The GUID that uniquely identifies an instance of the object.</param>
	///<param name="name">A Name</param>
	///
	public Sif3Assessment( string refId, string name ) : base( Adk.SifVersion, Sif3assessmentDTD.SIF3ASSESSMENT )
	{
		this.RefId = refId;
		this.Name = name;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Sif3Assessment( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { Sif3assessmentDTD.SIF3ASSESSMENT_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The GUID that uniquely identifies an instance of the object."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( Sif3assessmentDTD.SIF3ASSESSMENT_REFID ) ;
		}
		set
		{
			SetFieldValue( Sif3assessmentDTD.SIF3ASSESSMENT_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Name&gt;</c> element.
	/// </summary>
	/// <value> The <c>Name</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string Name
	{
		get
		{
			return (string) GetSifSimpleFieldValue( Sif3assessmentDTD.SIF3ASSESSMENT_NAME ) ;
		}
		set
		{
			SetFieldValue( Sif3assessmentDTD.SIF3ASSESSMENT_NAME, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;AssessmentIdentifiers&gt;</c> element.</summary>
	/// <param name="AssessmentIdentifier">An AssessmentIdentifier</param>
	///<remarks>
	/// <para>This form of <c>setAssessmentIdentifiers</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>AssessmentIdentifiers</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetAssessmentIdentifiers( AssessmentIdentifier AssessmentIdentifier ) {
		RemoveChild( Sif3assessmentDTD.SIF3ASSESSMENT_ASSESSMENTIDENTIFIERS);
		AddChild( Sif3assessmentDTD.SIF3ASSESSMENT_ASSESSMENTIDENTIFIERS, new AssessmentIdentifiers( AssessmentIdentifier ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssessmentIdentifiers&gt;</c> element.
	/// </summary>
	/// <value> An AssessmentIdentifiers </value>
	/// <remarks>
	/// <para>To remove the <c>AssessmentIdentifiers</c>, set <c>AssessmentIdentifiers</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public AssessmentIdentifiers AssessmentIdentifiers
	{
		get
		{
			return (AssessmentIdentifiers)GetChild( Sif3assessmentDTD.SIF3ASSESSMENT_ASSESSMENTIDENTIFIERS);
		}
		set
		{
			RemoveChild( Sif3assessmentDTD.SIF3ASSESSMENT_ASSESSMENTIDENTIFIERS);
			if( value != null)
			{
				AddChild( Sif3assessmentDTD.SIF3ASSESSMENT_ASSESSMENTIDENTIFIERS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssessmentPackageRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>AssessmentPackageRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string AssessmentPackageRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( Sif3assessmentDTD.SIF3ASSESSMENT_ASSESSMENTPACKAGEREFID ) ;
		}
		set
		{
			SetFieldValue( Sif3assessmentDTD.SIF3ASSESSMENT_ASSESSMENTPACKAGEREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssessmentDescriptors&gt;</c> element.
	/// </summary>
	/// <value> An AssessmentDescriptors </value>
	/// <remarks>
	/// <para>To remove the <c>AssessmentDescriptors</c>, set <c>AssessmentDescriptors</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public AssessmentDescriptors AssessmentDescriptors
	{
		get
		{
			return (AssessmentDescriptors)GetChild( Sif3assessmentDTD.SIF3ASSESSMENT_ASSESSMENTDESCRIPTORS);
		}
		set
		{
			RemoveChild( Sif3assessmentDTD.SIF3ASSESSMENT_ASSESSMENTDESCRIPTORS);
			if( value != null)
			{
				AddChild( Sif3assessmentDTD.SIF3ASSESSMENT_ASSESSMENTDESCRIPTORS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssessmentProvider&gt;</c> element.
	/// </summary>
	/// <value> The <c>AssessmentProvider</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string AssessmentProvider
	{
		get
		{
			return (string) GetSifSimpleFieldValue( Sif3assessmentDTD.SIF3ASSESSMENT_ASSESSMENTPROVIDER ) ;
		}
		set
		{
			SetFieldValue( Sif3assessmentDTD.SIF3ASSESSMENT_ASSESSMENTPROVIDER, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;AssessmentItemBanks&gt;</c> element.</summary>
	/// <param name="AssessmentItemBank">An AssessmentItemBank</param>
	///<remarks>
	/// <para>This form of <c>setAssessmentItemBanks</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>AssessmentItemBanks</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetAssessmentItemBanks( AssessmentItemBank AssessmentItemBank ) {
		RemoveChild( Sif3assessmentDTD.SIF3ASSESSMENT_ASSESSMENTITEMBANKS);
		AddChild( Sif3assessmentDTD.SIF3ASSESSMENT_ASSESSMENTITEMBANKS, new AssessmentItemBankList( AssessmentItemBank ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssessmentItemBanks&gt;</c> element.
	/// </summary>
	/// <value> An AssessmentItemBankList </value>
	/// <remarks>
	/// <para>To remove the <c>AssessmentItemBankList</c>, set <c>AssessmentItemBanks</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public AssessmentItemBankList AssessmentItemBanks
	{
		get
		{
			return (AssessmentItemBankList)GetChild( Sif3assessmentDTD.SIF3ASSESSMENT_ASSESSMENTITEMBANKS);
		}
		set
		{
			RemoveChild( Sif3assessmentDTD.SIF3ASSESSMENT_ASSESSMENTITEMBANKS);
			if( value != null)
			{
				AddChild( Sif3assessmentDTD.SIF3ASSESSMENT_ASSESSMENTITEMBANKS, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;AssessmentSubjects&gt;</c> element.</summary>
	/// <param name="SubjectArea">Subject matter.</param>
	///<remarks>
	/// <para>This form of <c>setAssessmentSubjects</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>AssessmentSubjects</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetAssessmentSubjects( SubjectArea SubjectArea ) {
		RemoveChild( Sif3assessmentDTD.SIF3ASSESSMENT_ASSESSMENTSUBJECTS);
		AddChild( Sif3assessmentDTD.SIF3ASSESSMENT_ASSESSMENTSUBJECTS, new SubjectAreaList( SubjectArea ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssessmentSubjects&gt;</c> element.
	/// </summary>
	/// <value> A SubjectAreaList </value>
	/// <remarks>
	/// <para>To remove the <c>SubjectAreaList</c>, set <c>AssessmentSubjects</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public SubjectAreaList AssessmentSubjects
	{
		get
		{
			return (SubjectAreaList)GetChild( Sif3assessmentDTD.SIF3ASSESSMENT_ASSESSMENTSUBJECTS);
		}
		set
		{
			RemoveChild( Sif3assessmentDTD.SIF3ASSESSMENT_ASSESSMENTSUBJECTS);
			if( value != null)
			{
				AddChild( Sif3assessmentDTD.SIF3ASSESSMENT_ASSESSMENTSUBJECTS, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;AssessmentGradeLevels&gt;</c> element.</summary>
	/// <param name="YearLevel">A YearLevel</param>
	///<remarks>
	/// <para>This form of <c>setAssessmentGradeLevels</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>AssessmentGradeLevels</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetAssessmentGradeLevels( YearLevel YearLevel ) {
		RemoveChild( Sif3assessmentDTD.SIF3ASSESSMENT_ASSESSMENTGRADELEVELS);
		AddChild( Sif3assessmentDTD.SIF3ASSESSMENT_ASSESSMENTGRADELEVELS, new YearLevels( YearLevel ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssessmentGradeLevels&gt;</c> element.
	/// </summary>
	/// <value> A YearLevels </value>
	/// <remarks>
	/// <para>To remove the <c>YearLevels</c>, set <c>AssessmentGradeLevels</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public YearLevels AssessmentGradeLevels
	{
		get
		{
			return (YearLevels)GetChild( Sif3assessmentDTD.SIF3ASSESSMENT_ASSESSMENTGRADELEVELS);
		}
		set
		{
			RemoveChild( Sif3assessmentDTD.SIF3ASSESSMENT_ASSESSMENTGRADELEVELS);
			if( value != null)
			{
				AddChild( Sif3assessmentDTD.SIF3ASSESSMENT_ASSESSMENTGRADELEVELS, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;AssessmentLanguages&gt;</c> element.</summary>
	/// <param name="Language">A Language</param>
	///<remarks>
	/// <para>This form of <c>setAssessmentLanguages</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>AssessmentLanguages</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetAssessmentLanguages( Language Language ) {
		RemoveChild( Sif3assessmentDTD.SIF3ASSESSMENT_ASSESSMENTLANGUAGES);
		AddChild( Sif3assessmentDTD.SIF3ASSESSMENT_ASSESSMENTLANGUAGES, new LanguageList( Language ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssessmentLanguages&gt;</c> element.
	/// </summary>
	/// <value> A LanguageList </value>
	/// <remarks>
	/// <para>To remove the <c>LanguageList</c>, set <c>AssessmentLanguages</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public LanguageList AssessmentLanguages
	{
		get
		{
			return (LanguageList)GetChild( Sif3assessmentDTD.SIF3ASSESSMENT_ASSESSMENTLANGUAGES);
		}
		set
		{
			RemoveChild( Sif3assessmentDTD.SIF3ASSESSMENT_ASSESSMENTLANGUAGES);
			if( value != null)
			{
				AddChild( Sif3assessmentDTD.SIF3ASSESSMENT_ASSESSMENTLANGUAGES, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;LearningStandardItemRefIds&gt;</c> element.</summary>
	/// <param name="LearningStandardItemRefId">A LearningStandardItemRefId</param>
	///<remarks>
	/// <para>This form of <c>setLearningStandardItemRefIds</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>LearningStandardItemRefIds</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetLearningStandardItemRefIds( LearningStandardItemRefId LearningStandardItemRefId ) {
		RemoveChild( Sif3assessmentDTD.SIF3ASSESSMENT_LEARNINGSTANDARDITEMREFIDS);
		AddChild( Sif3assessmentDTD.SIF3ASSESSMENT_LEARNINGSTANDARDITEMREFIDS, new LearningStandardItems( LearningStandardItemRefId ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;LearningStandardItemRefIds&gt;</c> element.
	/// </summary>
	/// <value> A LearningStandardItems </value>
	/// <remarks>
	/// <para>To remove the <c>LearningStandardItems</c>, set <c>LearningStandardItemRefIds</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public LearningStandardItems LearningStandardItemRefIds
	{
		get
		{
			return (LearningStandardItems)GetChild( Sif3assessmentDTD.SIF3ASSESSMENT_LEARNINGSTANDARDITEMREFIDS);
		}
		set
		{
			RemoveChild( Sif3assessmentDTD.SIF3ASSESSMENT_LEARNINGSTANDARDITEMREFIDS);
			if( value != null)
			{
				AddChild( Sif3assessmentDTD.SIF3ASSESSMENT_LEARNINGSTANDARDITEMREFIDS, value );
			}
		}
	}

}}