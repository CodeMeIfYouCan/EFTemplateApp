﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Modules.NorthWind.Data.Resources
{
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Queries {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Queries() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Modules.NorthWind.Data.Resources.Queries", typeof(Queries).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to USE [CustomerDb]
        ///GO
        ////****** Object:  StoredProcedure [CUS].[CUSTOMERS_SELECT]    Script Date: 25.12.2017 15:10:02 ******/
        ///SET ANSI_NULLS ON
        ///GO
        ///SET QUOTED_IDENTIFIER ON
        ///GO
        ///
        ///-- Sunucu: s0134dbdev02
        ///-- Veritabanı: CustomerDB
        ///
        ///-- ==========================================================================================
        ///-- Author:SedaOzy
        ///-- Create date:24.07.2013
        ///-- Description: Temel musteri bilgisini listeler
        ///-- ====================================================================================== [rest of string was truncated]&quot;;.
        /// </summary>
        public static string CUS_CUSTOMERS_SELECT {
            get {
                return ResourceManager.GetString("CUS_CUSTOMERS_SELECT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT [Id]
        ///      ,[ExternalClientNo]
        ///      ,[ChannelNo]
        ///      ,[MainBranchCode]
        ///      ,[SystemEntryDate]
        ///      ,[EntryDate]
        ///      ,[LastModifiedBy]
        ///      ,[CustomerType]
        ///      ,[UnitStatus]
        ///      ,[Name]
        ///      ,[MiddleName]
        ///      ,[Surname]
        ///      ,[FirmName]
        ///      ,[ShortName]
        ///      ,[Profile]
        ///      ,[SegmentCode]
        ///      ,[TaxOffice]
        ///      ,[TaxNo]
        ///      ,[CitizenshipNumber]
        ///      ,[IdentityType]
        ///      ,[IdentityNo]
        ///      ,[DrivingLicenceNo]
        ///      ,[IBSeries]
        ///      ,[IBSerialNo]
        ///     [rest of string was truncated]&quot;;.
        /// </summary>
        public static string CUSTOMER_SELECT {
            get {
                return ResourceManager.GetString("CUSTOMER_SELECT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT [Id]
        ///  FROM dbo.Customers(nolock)
        ///where ExternalClientNo = {0} and
        ///  Id = {1} .
        /// </summary>
        public static string CUSTOMER_SELECT_test1y {
            get {
                return ResourceManager.GetString("CUSTOMER_SELECT_test1y", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT [Id]
        ///      ,[ExternalClientNo]
        ///      ,[ChannelNo]
        ///      ,[MainBranchCode]
        ///      ,[SystemEntryDate]
        ///      ,[EntryDate]
        ///      ,[LastModifiedBy]
        ///      ,[CustomerType]
        ///      ,[UnitStatus]
        ///      --,[Name]
        ///      ,[MiddleName]
        ///      ,[Surname]
        ///      ,[FirmName]
        ///      ,[ShortName]
        ///      ,[Profile]
        ///      ,[SegmentCode]
        ///      ,[TaxOffice]
        ///      ,[TaxNo]
        ///      ,[CitizenshipNumber]
        ///      ,[IdentityType]
        ///      ,[IdentityNo]
        ///      ,[DrivingLicenceNo]
        ///      ,[IBSeries]
        ///      ,[IBSerialNo]
        ///   [rest of string was truncated]&quot;;.
        /// </summary>
        public static string CUSTOMER_SELECT_WITH_PARAMS {
            get {
                return ResourceManager.GetString("CUSTOMER_SELECT_WITH_PARAMS", resourceCulture);
            }
        }
    }
}
