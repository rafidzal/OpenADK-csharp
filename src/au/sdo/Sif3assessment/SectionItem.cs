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

/// <summary>A SectionItem</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.6</para>
/// </remarks>
[Serializable]
public class SectionItem : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a SectionItem
	/// </summary>
	public SectionItem() : base ( Sif3assessmentDTD.SECTIONITEM ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="assessmentItemRefId">An AssessmentItemRefId</param>
	///
	public SectionItem( string assessmentItemRefId ) : base( Sif3assessmentDTD.SECTIONITEM )
	{
		this.AssessmentItemRefId = assessmentItemRefId;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected SectionItem( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { Sif3assessmentDTD.SECTIONITEM_ASSESSMENTITEMREFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssessmentItemRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>AssessmentItemRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string AssessmentItemRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( Sif3assessmentDTD.SECTIONITEM_ASSESSMENTITEMREFID ) ;
		}
		set
		{
			SetFieldValue( Sif3assessmentDTD.SECTIONITEM_ASSESSMENTITEMREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ItemSequence&gt;</c> element.
	/// </summary>
	/// <value> The <c>ItemSequence</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string ItemSequence
	{
		get
		{
			return (string) GetSifSimpleFieldValue( Sif3assessmentDTD.SECTIONITEM_ITEMSEQUENCE ) ;
		}
		set
		{
			SetFieldValue( Sif3assessmentDTD.SECTIONITEM_ITEMSEQUENCE, new SifString( value ), value );
		}
	}

}}