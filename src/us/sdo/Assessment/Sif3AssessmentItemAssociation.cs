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

/// <summary>A Sif3AssessmentItemAssociation</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.6</para>
/// </remarks>
[Serializable]
public class Sif3AssessmentItemAssociation : SifDataObject
{
	/// <summary>
	/// Creates an instance of a Sif3AssessmentItemAssociation
	/// </summary>
	public Sif3AssessmentItemAssociation() : base( Adk.SifVersion, AssessmentDTD.SIF3ASSESSMENTITEMASSOCIATION ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">The GUID that uniquely identifies an instance of this object.</param>
	///<param name="assessmentItemRefId">The first item in the association.</param>
	///<param name="targetAssessmentItemRefId">The item being associated to the first item.</param>
	///<param name="associationType">Indicates the type of association.</param>
	///
	public Sif3AssessmentItemAssociation( string refId, string assessmentItemRefId, string targetAssessmentItemRefId, AssociationType associationType ) : base( Adk.SifVersion, AssessmentDTD.SIF3ASSESSMENTITEMASSOCIATION )
	{
		this.RefId = refId;
		this.AssessmentItemRefId = assessmentItemRefId;
		this.TargetAssessmentItemRefId = targetAssessmentItemRefId;
		this.SetAssociationType( associationType );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Sif3AssessmentItemAssociation( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { AssessmentDTD.SIF3ASSESSMENTITEMASSOCIATION_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The GUID that uniquely identifies an instance of this object."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.SIF3ASSESSMENTITEMASSOCIATION_REFID ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.SIF3ASSESSMENTITEMASSOCIATION_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssessmentItemRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>AssessmentItemRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The first item in the association."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string AssessmentItemRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.SIF3ASSESSMENTITEMASSOCIATION_ASSESSMENTITEMREFID ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.SIF3ASSESSMENTITEMASSOCIATION_ASSESSMENTITEMREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;TargetAssessmentItemRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>TargetAssessmentItemRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The item being associated to the first item."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string TargetAssessmentItemRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.SIF3ASSESSMENTITEMASSOCIATION_TARGETASSESSMENTITEMREFID ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.SIF3ASSESSMENTITEMASSOCIATION_TARGETASSESSMENTITEMREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssociationType&gt;</c> element.
	/// </summary>
	/// <value> The <c>AssociationType</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Indicates the type of association."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string AssociationType
	{
		get
		{ 
			return GetFieldValue( AssessmentDTD.SIF3ASSESSMENTITEMASSOCIATION_ASSOCIATIONTYPE );
		}
		set
		{
			SetField( AssessmentDTD.SIF3ASSESSMENTITEMASSOCIATION_ASSOCIATIONTYPE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;AssociationType&gt;</c> element.
	/// </summary>
	/// <param name="val">A AssociationType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Indicates the type of association."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetAssociationType( AssociationType val )
	{
		SetField( AssessmentDTD.SIF3ASSESSMENTITEMASSOCIATION_ASSOCIATIONTYPE, val );
	}

}}
