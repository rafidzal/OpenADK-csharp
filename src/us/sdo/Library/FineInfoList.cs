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

namespace OpenADK.Library.us.Library{

/// <summary>A FineInfoList</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.1</para>
/// </remarks>
[Serializable]
public class FineInfoList : SifKeyedList<FineInfo>
{
	/// <summary>
	/// Creates an instance of a FineInfoList
	/// </summary>
	public FineInfoList() : base ( LibraryDTD.FINEINFOLIST ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="fineInfo">A FineInfo</param>
	///
	public FineInfoList( FineInfo fineInfo ) : base( LibraryDTD.FINEINFOLIST )
	{
		this.SafeAddChild( LibraryDTD.FINEINFOLIST_FINEINFO, fineInfo );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected FineInfoList( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	///<summary>Adds the value of the <c>&lt;FineInfo&gt;</c> element.</summary>
	/// <param name="Type">Type of fine assessed to this patron and item.  A corresponding ItemInfo is required for all FineInfo types except "Other" and "Refund" where it is permissible to omit the ItemInfo element if there isn't an item associated with the fine.</param>
	/// <param name="Assessed">The date and time that this fine was assessed to the patron.</param>
	/// <param name="Amount">The current balance of the fine expressed as a positive number. </param>
	///<remarks>
	/// <para>This form of <c>setFineInfo</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddFineInfo</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public void AddFineInfo( FineType Type, DateTime? Assessed, MonetaryAmount Amount ) {
		AddChild( LibraryDTD.FINEINFOLIST_FINEINFO, new FineInfo( Type, Assessed, Amount ) );
	}

}}
