// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.au.Common
{
	///<summary>
	/// Defines the set of values that can be specified whenever an AU0600DwellingArrangementType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  an AU0600DwellingArrangementType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	[Serializable]
	public class AU0600DwellingArrangementType : SifEnum
	{
	/// <summary>Other dormitory ("1681")</summary>
	public static readonly AU0600DwellingArrangementType C1681_OT_DORMITORY = new AU0600DwellingArrangementType("1681");

	/// <summary>Foster home ("1675")</summary>
	public static readonly AU0600DwellingArrangementType C1675_FOSTER_HOME = new AU0600DwellingArrangementType("1675");

	/// <summary>Rooming house ("1678")</summary>
	public static readonly AU0600DwellingArrangementType C1678_ROOMING_HOUSE = new AU0600DwellingArrangementType("1678");

	/// <summary>Disaster shelter ("1672")</summary>
	public static readonly AU0600DwellingArrangementType C1672_DISASTER_SHELTER = new AU0600DwellingArrangementType("1672");

	/// <summary>Boarder ("4000")</summary>
	public static readonly AU0600DwellingArrangementType C4000_BOARDER = new AU0600DwellingArrangementType("4000");

	/// <summary>Family residence - One Parent/Guardian ("167o")</summary>
	public static readonly AU0600DwellingArrangementType C167o_FAMILY_RESIDENCE_ONE_PARENT = new AU0600DwellingArrangementType("167o");

	/// <summary>Cooperative house ("1670")</summary>
	public static readonly AU0600DwellingArrangementType C1670_COOPERATIVE_HOUSE = new AU0600DwellingArrangementType("1670");

	/// <summary>Prison or juvenile detention center ("1677")</summary>
	public static readonly AU0600DwellingArrangementType C1677_PRISON_OR_JUVENILE_DETENTION = new AU0600DwellingArrangementType("1677");

	/// <summary>Independent ("167I")</summary>
	public static readonly AU0600DwellingArrangementType C167I_INDEPENDENT = new AU0600DwellingArrangementType("167I");

	/// <summary>No home (Homeless Youth) ("1680")</summary>
	public static readonly AU0600DwellingArrangementType C1680_NO_HOME_HOMELESS_YOUTH = new AU0600DwellingArrangementType("1680");

	/// <summary>Institution ("1676")</summary>
	public static readonly AU0600DwellingArrangementType C1676_INSTITUTION = new AU0600DwellingArrangementType("1676");

	/// <summary>Group home/halfway house ("3425")</summary>
	public static readonly AU0600DwellingArrangementType C3425_GROUP_HOME_HALFWAY = new AU0600DwellingArrangementType("3425");

	/// <summary>Residential school/dormitory ("1673")</summary>
	public static readonly AU0600DwellingArrangementType C1673_RESIDENTIAL_SCHOOL = new AU0600DwellingArrangementType("1673");

	/// <summary>Transient shelter ("1679")</summary>
	public static readonly AU0600DwellingArrangementType C1679_TRANSIENT_SHELTER = new AU0600DwellingArrangementType("1679");

	/// <summary>Crisis shelter ("1671")</summary>
	public static readonly AU0600DwellingArrangementType C1671_CRISIS_SHELTER = new AU0600DwellingArrangementType("1671");

	/// <summary>Boarding house ("1669")</summary>
	public static readonly AU0600DwellingArrangementType C1669_BOARDING_HOUSE = new AU0600DwellingArrangementType("1669");

	/// <summary>Family residence - Both Parents/Guardians ("1674")</summary>
	public static readonly AU0600DwellingArrangementType C1674_FAMILY_RESIDENCE_BOTH_PARENTS = new AU0600DwellingArrangementType("1674");

	/// <summary>Arranged by State - Out of Home Care ("168A")</summary>
	public static readonly AU0600DwellingArrangementType C168A_ARRANGED_BY_STATE_OUT_OF_HOME = new AU0600DwellingArrangementType("168A");

	/// <summary>Other ("9999")</summary>
	public static readonly AU0600DwellingArrangementType C9999_OTHER = new AU0600DwellingArrangementType("9999");

	///<summary>Wrap an arbitrary string value in an AU0600DwellingArrangementType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static AU0600DwellingArrangementType Wrap( String wrappedValue ) {
		return new AU0600DwellingArrangementType( wrappedValue );
	}

	private AU0600DwellingArrangementType( string enumDefValue ) : base( enumDefValue ) {}
	}
}
