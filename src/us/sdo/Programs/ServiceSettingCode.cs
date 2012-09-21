// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.us.Programs
{
	///<summary>
	/// Defines the set of values that can be specified whenever a ServiceSettingCode
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a ServiceSettingCode object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	[Serializable]
	public class ServiceSettingCode : SifEnum
	{
	/// <summary>Hospital placement instruction ("0129")</summary>
	public static readonly ServiceSettingCode HOSPITAL_PLACEMENT_INSTRUCTION = new ServiceSettingCode("0129");

	/// <summary>Special education classroom im child care facility ("2184")</summary>
	public static readonly ServiceSettingCode SPECIAL_EDU_CHILDCARE = new ServiceSettingCode("2184");

	/// <summary>Early intervention classroom / center ("0127")</summary>
	public static readonly ServiceSettingCode EARLY_INTERVENTION_CLASSROOM = new ServiceSettingCode("0127");

	/// <summary>Other ("9999")</summary>
	public static readonly ServiceSettingCode OTHER = new ServiceSettingCode("9999");

	/// <summary>Community-based agency representative ("0166")</summary>
	public static readonly ServiceSettingCode COMMUNITY_BASED_AGENCY = new ServiceSettingCode("0166");

	/// <summary>Special education classroom in trailers or portables outside regular school buildings ("2189")</summary>
	public static readonly ServiceSettingCode SPECIAL_EDU_PORTABLE = new ServiceSettingCode("2189");

	/// <summary>Separate class placement ("0137")</summary>
	public static readonly ServiceSettingCode SEPARATE_CLASS_PLACEMENT = new ServiceSettingCode("0137");

	/// <summary>Private residential placement ("0132")</summary>
	public static readonly ServiceSettingCode PRIVATE_RESIDENTIAL_PLACEMENT = new ServiceSettingCode("0132");

	/// <summary>Other childcare facility ("2191")</summary>
	public static readonly ServiceSettingCode OTHER_CHILDCARE = new ServiceSettingCode("2191");

	/// <summary>Religion-affiliated institution ("2169")</summary>
	public static readonly ServiceSettingCode RELIGION_AFFILIATED_INSTITUTIO = new ServiceSettingCode("2169");

	/// <summary>Head Start Center (no matter where offered) ("2168")</summary>
	public static readonly ServiceSettingCode HEAD_START_CENTER = new ServiceSettingCode("2168");

	/// <summary>Public separate day school placement ("0135")</summary>
	public static readonly ServiceSettingCode PUBLIC_SEPARATE_DAY_SCHOOL = new ServiceSettingCode("0135");

	/// <summary>Outpatient service facility ("0356")</summary>
	public static readonly ServiceSettingCode OUTPATIENT_SERVICE_FACILITY = new ServiceSettingCode("0356");

	/// <summary>Special education classroom in regular school building ("2185")</summary>
	public static readonly ServiceSettingCode SPECIAL_EDU_BUILDING = new ServiceSettingCode("2185");

	/// <summary>Public residential placement ("0134")</summary>
	public static readonly ServiceSettingCode PUBLIC_RESIDENTIAL_PLACEMENT = new ServiceSettingCode("0134");

	/// <summary>facility sponsored by a state agency ("2190")</summary>
	public static readonly ServiceSettingCode FACILITY_STATE = new ServiceSettingCode("2190");

	/// <summary>Homebound placement instruction ("0128")</summary>
	public static readonly ServiceSettingCode HOMEBOUND_PLACEMENT_INSTRUCTIO = new ServiceSettingCode("0128");

	/// <summary>Resource room placement (pullout program) ("0136")</summary>
	public static readonly ServiceSettingCode RESOURCE_ROOM_PLACEMENT = new ServiceSettingCode("0136");

	/// <summary>A center in a facility other than a public or private school, a day care or children's facility, or other public programs such as Head Start ("2191")</summary>
	public static readonly ServiceSettingCode FACILITY_OTHER = new ServiceSettingCode("2191");

	/// <summary>Hospital facility ("2187")</summary>
	public static readonly ServiceSettingCode HOSPITAL_FACILITY = new ServiceSettingCode("2187");

	/// <summary>Residential facility ("0756")</summary>
	public static readonly ServiceSettingCode RESIDENTIAL_FACILITY = new ServiceSettingCode("0756");

	/// <summary>University / Postsecondary institution ("2172")</summary>
	public static readonly ServiceSettingCode UNIVERSITY_POSTSECONDARY = new ServiceSettingCode("2172");

	/// <summary>Regular nursery school / child care center ("0365")</summary>
	public static readonly ServiceSettingCode REGULAR_NURSERY_SCHOOL = new ServiceSettingCode("0365");

	/// <summary>Home ("2192")</summary>
	public static readonly ServiceSettingCode HOME = new ServiceSettingCode("2192");

	/// <summary>Shelter or ophanage ("2174")</summary>
	public static readonly ServiceSettingCode SHELTER_OR_OPHANAGE = new ServiceSettingCode("2174");

	/// <summary>Private school or childcare facility ("2167")</summary>
	public static readonly ServiceSettingCode PRIVATE_SCHOOL_OR_CHILDCARE = new ServiceSettingCode("2167");

	/// <summary>Hospital or other treatment center ("2173")</summary>
	public static readonly ServiceSettingCode HOSPITAL_OR_OTHER_TREATMENT = new ServiceSettingCode("2173");

	/// <summary>Public school facility ("2166")</summary>
	public static readonly ServiceSettingCode PUBLIC_SCHOOL_FACILITY = new ServiceSettingCode("2166");

	/// <summary>Business / workplace ("2170")</summary>
	public static readonly ServiceSettingCode BUSINESS_WORKPLACE = new ServiceSettingCode("2170");

	/// <summary>Respite care ("0367")</summary>
	public static readonly ServiceSettingCode RESPITE_CARE = new ServiceSettingCode("0367");

	/// <summary>Short-term detention facility ("0364")</summary>
	public static readonly ServiceSettingCode SHORT_TERM_DETENTION = new ServiceSettingCode("0364");

	/// <summary>Child's home ("2164")</summary>
	public static readonly ServiceSettingCode CHILDS_HOME = new ServiceSettingCode("2164");

	/// <summary>Reverse mainstream setting ("0143")</summary>
	public static readonly ServiceSettingCode REVERSE_MAINSTREAM_SETTING = new ServiceSettingCode("0143");

	/// <summary>Private separate day school placement ("0358")</summary>
	public static readonly ServiceSettingCode PRIVATE_SEPARATE_DAY_SCHOOL = new ServiceSettingCode("0358");

	/// <summary>Home other than the child's ("2165")</summary>
	public static readonly ServiceSettingCode HOME_OTHER_THAN_THE_CHILDS = new ServiceSettingCode("2165");

	/// <summary>Other community-based setting ("2188")</summary>
	public static readonly ServiceSettingCode OTHER_COMMUNITY_BASED = new ServiceSettingCode("2188");

	/// <summary>Regular school campus / regular class placement ("0130")</summary>
	public static readonly ServiceSettingCode REGULAR_SCHOOL_CAMPUS = new ServiceSettingCode("0130");

	/// <summary>Itinerant services outside the home ("0140")</summary>
	public static readonly ServiceSettingCode ITINERANT_SERVICES_OUTSIDE = new ServiceSettingCode("0140");

	/// <summary>Private School ("0776")</summary>
	public static readonly ServiceSettingCode PRIVATE_SCHOOL = new ServiceSettingCode("0776");

	///<summary>Wrap an arbitrary string value in a ServiceSettingCode object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static ServiceSettingCode Wrap( String wrappedValue ) {
		return new ServiceSettingCode( wrappedValue );
	}

	private ServiceSettingCode( string enumDefValue ) : base( enumDefValue ) {}
	}
}