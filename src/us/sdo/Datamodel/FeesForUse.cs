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

namespace OpenADK.Library.us.Datamodel{

/// <summary>A container for fees for use of the content in the object.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class FeesForUse : SifKeyedList<FeeForUse>
{
	/// <summary>
	/// Creates an instance of a FeesForUse
	/// </summary>
	public FeesForUse() : base ( DatamodelDTD.FEESFORUSE ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="feeForUse">A FeeForUse</param>
	///
	public FeesForUse( FeeForUse feeForUse ) : base( DatamodelDTD.FEESFORUSE )
	{
		this.SafeAddChild( DatamodelDTD.FEESFORUSE_FEEFORUSE, feeForUse );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected FeesForUse( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	///<summary>Adds the value of the <c>&lt;FeeForUse&gt;</c> element.</summary>
	/// <param name="MeteringType">A MeteringType</param>
	///<remarks>
	/// <para>This form of <c>setFeeForUse</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddFeeForUse</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void AddFeeForUse( string MeteringType ) {
		AddChild( DatamodelDTD.FEESFORUSE_FEEFORUSE, new FeeForUse( MeteringType ) );
	}

}}