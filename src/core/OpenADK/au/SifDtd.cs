// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using OpenADK.Util;
using OpenADK.Library;
using OpenADK.Library.Impl;

namespace OpenADK.Library.au
{
using System.Text;

// BEGIN FILE... (SIFDTD_Comments_CS.txt)

/// <summary>Metadata for the Schools Interoperability Framework (SIF)</summary>
	/// <remarks>
	/// <para>
	/// SIFDTD defines global {@linkplain com.edustructures.sifworks.ElementDef} 
	/// constants that describe SIF Data Objects, elements, and attributes across all 
	/// supported versions of the SIF Specification. The ADK uses this metadata 
	/// internally to parse and render SIF Data Objects.  In addition, many of the 
	/// framework APIs require that the programmer pass an ElementDef constant from 
	/// the SIFDTD class to identify an object, element, or attribute.
	/// </para>
	/// <para>
	/// ElementDef constants are named <c>[PARENT_]ENTITY</c>, where 
	/// <c>PARENT</c> is the name of the parent element and 
	/// <c>ENTITY</c> is the name of the element or attribute 
	/// encapsulated by the ElementDef. Some examples of ElementDef constants defined
	/// by this class include:
	/// </para>
	/// <list type="table">
	/// <listheader><term>IElementDef</term><description>Description</description></listheader>
	/// <item><term><c>SIFDTD.STUDENTPERSONAL</c></term><description>Identifies the StudentPersonal data object</description></item>
	/// <item><term><c>SIFDTD.SCHOOLINFO</c></term><description>Identifies the SchoolInfo data object</description></item>
	/// </list>
	/// Many of the Adk's public interfaces require an ElementDef constant to be passed
	/// as a parameter. For example, the first parameter to the <see cref="IZone.SetSubscriber"/>
	/// method is an IElementDef:
	/// <code>myZone.setSubscriber( SIFDTD.BUSINFO, this, ADKFlags.PROV_SUBSCRIBE );</code>
	/// ElementDef also identifies child elements and attributes as demonstrated by the	<c>Query.AddCondition</c> method:
	/// <code>
	/// Query query = new Query( SifDtd.STUDENTPERSONAL );
	/// query.AddCondition( SifDtd.STUDENTPERSONAL_REFID, Condition.EQ, "4A37969803F0D00322AF0EB969038483" );
	/// </code>
	/// <para>
	/// <b>SDO Libraries</b>
	/// </para>
	/// <para>
	/// ElementDef metadata is grouped into "SDO Libraries", which are organized along 
	/// SIF Working Group boundaries. SDO Libraries are loaded into the <c>SifDdt</c> 
	/// class when the Adk is initialized. All or part of the metadata is loaded into depending on the flags passed to the
	/// <see cref="Adk.Initialize(SifVersion, SdoLibraryType)"/> method,
	/// metadata from one or more SDO Libraries may be loaded. For example, the following
	/// call loads metadata for the <c>Student Information Working Group Objects</c>  
	/// and <c>Transportation And Geographic Information Working Group Objects</c> 
	/// (Common Elements and <c>Infrastructure Working Group Objects</c> metadata is always loaded
	/// </para>
	/// <code>Adk.Initialize( SiFVersion.LATEST, SdoLibraryType.Student | SdoLibraryType.Trans )</code>
	/// <para>
	/// If an given SDO Library is not loaded, all of the SIFDTD constants that belong
	/// to that library will be <code>null</code> and cannot be referenced. For example,
	/// given the SDO Libraries loaded above, attempting to reference the 
	/// <code>SIFDTD.LIBRARYPATRONSTATUS</code> object from the Library Automation Working
	/// Group would result in a NullPointerException:
	/// </para>
	/// <code>SifDtd.LIBRARYPATRONSTATUS.Name;</code>
	/// </remarks>
public sealed partial class SifDtd : OpenADK.Library.SifDtd
{
	// Declare all object and field elements defined by all versions of SIF
	// supported by the class framework.

	// Package names that comprise the SIF Data Objects library
	/** The name of the null package */
	public const string DW = "Dw";
	/** The name of the null package */
	public const string SYSTEM = "System";
	/** The name of the null package */
	public const string ASSESSMENT = "Assessment";
	/** The name of the null package */
	public const string PROGRAMS = "Programs";
	/** The name of the null package */
	public const string SCHOOL = "School";
	/** The name of the null package */
	public const string STUDENT = "Student";
	/** The name of the null package */
	public const string LEARNING = "Learning";
	/** The name of the null package */
	public const string REPORTING = "Reporting";
	/** The name of the null package */
	public const string GRADEBOOK = "Gradebook";
	/** The name of the Infrastructure package */
	public const string INFRASTRUCTURE = "Infrastructure";

	// The name of the data model variant this class is defined in
	public override string Variant { 
		get{
			return "au";
		}
	}
	public override List<string> LoadedLibraryNames
	{
	get
			{
			List<string> libNames = new List<string>();

			int[] availableValues = (int[])Enum.GetValues(typeof(SdoLibraryType));

			foreach (int a in availableValues)
			{
				if (a != (int)SdoLibraryType.All && (fLoaded & a) != 0)
				{
					libNames.Add(GetLibraryName(a));
				}
			}

			return libNames;
		}
	}

	/** The base xmlns for this edition of the ADK without the version */
	public override string XMLNS_BASE {
		get{
			return "http://www.sifinfo.org/au/infrastructure";
		}
	}

	internal static IDictionary<String,IElementDef> sElementDefs = new Dictionary<String,IElementDef>( 403 );
	static SifDtd()
	{
		sElementDefs[ "SIF_Message" ] = SIF_MESSAGE;
		sElementDefs[ "SIF_Message_Version" ] = SIF_MESSAGE_VERSION;
	}



// BEGIN EXTRA METHODS (SIFDTD_Template_CS.txt)


    protected override String GetLibraryName(int type)
    {
        return ((SdoLibraryType)type).ToString("G");
    }
	


    /// <summary>  Gets the names of all Sdo libraries offered with this version of the Adk (Excluding Common, DataModel, and Infra)</summary>
    public override int[] AvailableLibraries
    {
        //TODO: Look at this signature to see if it can be changed back to SDOLibraryType
        get { return GetSdoTypes( (int)SdoLibraryType.All ^ (IntrinsicLibraries)).ToArray(); }
    }

    /// <summary>
    /// Determines if the specified SDO library is loaded
    /// <param name="library">The library identifier (e.g. SdoLibraryType.Reporting)</param>
    /// <returns></returns>
    public bool IsLibraryLoaded(SdoLibraryType library)
    {
        return (fLoaded & (int)library) != 0;
    }


    /// <summary>
    /// Gets an integer identifying all loaded libraries
    /// </summary>
    public SdoLibraryType LoadedLibraries
    {
        get { return (SdoLibraryType)fLoaded; }
    }

    protected override List<int> GetSdoTypes(int libraryTypes)
    {
        List<int> libTypes = new List<int>();

        int[] availableValues = (int[])Enum.GetValues(typeof(SdoLibraryType));
        foreach (int a in availableValues)
        {
            if ((((int)libraryTypes & a) > 0) && a != (int)SdoLibraryType.All)
            {
                libTypes.Add(a);
            }
        }
        return libTypes;

    }

// END EXTRA METHODS

}}
