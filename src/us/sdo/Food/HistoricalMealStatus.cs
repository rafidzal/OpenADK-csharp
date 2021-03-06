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

namespace OpenADK.Library.us.Food{

/// <summary>An HistoricalMealStatus</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class HistoricalMealStatus : SifKeyedList<MealStatus>
{
	/// <summary>
	/// Creates an instance of an HistoricalMealStatus
	/// </summary>
	public HistoricalMealStatus() : base ( FoodDTD.HISTORICALMEALSTATUS ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="mealStatus">
	///         The student's meal status.  Note that as this status is historical, StartDate and EndDate together,
	///         and/or SchoolYear MUST be included.  If SchoolYear is included,
	///         StartDate and EndDate should not cross school year boundaries, i.e. in addition to multiple
	///         statuses being a possibility in a given school year, the same status may be repeated so StartDate and EndDate don't
	///         disagree with SchoolYear, if included.
	///       </param>
	///
	public HistoricalMealStatus( MealStatus mealStatus ) : base( FoodDTD.HISTORICALMEALSTATUS )
	{
		this.SafeAddChild( FoodDTD.HISTORICALMEALSTATUS_MEALSTATUS, mealStatus );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected HistoricalMealStatus( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	///<summary>Adds the value of the <c>&lt;MealStatus&gt;</c> element.</summary>
	/// <param name="Type">Meal status type.</param>
	///<remarks>
	/// <para>This form of <c>setMealStatus</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddMealStatus</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void AddMealStatus( FreeReducedStatus Type ) {
		AddChild( FoodDTD.HISTORICALMEALSTATUS_MEALSTATUS, new MealStatus( Type ) );
	}

}}
