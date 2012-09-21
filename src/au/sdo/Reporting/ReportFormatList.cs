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
using OpenADK.Library.Infra;

namespace OpenADK.Library.au.Reporting{

/// <summary>A ReportFormatList</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.3</para>
/// </remarks>
[Serializable]
public class ReportFormatList : SifList<ReportFormat>
{
	/// <summary>
	/// Creates an instance of a ReportFormatList
	/// </summary>
	public ReportFormatList() : base ( ReportingDTD.REPORTFORMATLIST ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="reportFormat">A third-party format that describes the visual representation of the report data.</param>
	///
	public ReportFormatList( ReportFormat reportFormat ) : base( ReportingDTD.REPORTFORMATLIST )
	{
		this.SafeAddChild( ReportingDTD.REPORTFORMATLIST_REPORTFORMAT, reportFormat );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected ReportFormatList( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { ReportingDTD.REPORTFORMATLIST_REPORTFORMAT }; }
	}

	///<summary>Adds the value of the <c>&lt;ReportFormat&gt;</c> element.</summary>
	/// <param name="Type">This attribute indicates the encoding of the format reference.</param>
	/// <param name="ContentType">The vendor-defined content type (e.g. com.vendor.format, PDF, etc.</param>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;ReportFormat&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setReportFormat</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddReportFormat</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void AddReportFormat( ReportFormatType Type, string ContentType, string Value ) {
		AddChild( ReportingDTD.REPORTFORMATLIST_REPORTFORMAT, new ReportFormat( Type, ContentType, Value ) );
	}

}}