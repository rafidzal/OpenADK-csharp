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

namespace OpenADK.Library.au.Assessment{

/// <summary>A FormNumbers</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.4</para>
/// </remarks>
[Serializable]
public class FormNumbers : SifKeyedList<FormNumber>
{
	/// <summary>
	/// Creates an instance of a FormNumbers
	/// </summary>
	public FormNumbers() : base ( AssessmentDTD.FORMNUMBERS ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="formNumber">Reference number for the form.</param>
	///
	public FormNumbers( FormNumber formNumber ) : base( AssessmentDTD.FORMNUMBERS )
	{
		this.SafeAddChild( AssessmentDTD.FORMNUMBERS_FORMNUMBER, formNumber );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected FormNumbers( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { AssessmentDTD.FORMNUMBERS_FORMNUMBER }; }
	}

	///<summary>Adds the value of the <c>&lt;FormNumber&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;FormNumber&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setFormNumber</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddFormNumber</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void AddFormNumber( string Value ) {
		AddChild( AssessmentDTD.FORMNUMBERS_FORMNUMBER, new FormNumber( Value ) );
	}

}}
