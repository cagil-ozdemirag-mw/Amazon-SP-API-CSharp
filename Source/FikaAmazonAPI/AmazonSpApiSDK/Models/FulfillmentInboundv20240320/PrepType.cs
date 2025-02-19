/* 
 * The Selling Partner API for FBA inbound operations.
 *
 * The Selling Partner API for Fulfillment By Amazon (FBA) Inbound. The FBA Inbound API enables building inbound workflows to create, manage, and send shipments into Amazon's fulfillment network. The API has interoperability with the Send-to-Amazon user interface.
 *
 * OpenAPI spec version: 2024-03-20
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentInboundv20240320
{
    /// <summary>
    /// Type of preparation that should be done. Can be: ITEM_LABELING, ITEM_BUBBLEWRAP, ITEM_POLYBAGGING, ITEM_TAPING, ITEM_BLACK_SHRINKWRAP, ITEM_HANG_GARMENT, ITEM_BOXING, ITEM_SETCREAT, ITEM_RMOVHANG, ITEM_SUFFOSTK, ITEM_CAP_SEALING, ITEM_DEBUNDLE, ITEM_SETSTK, ITEM_SIOC, ITEM_NO_PREP, ADULT, BABY, TEXTILE, HANGER, FRAGILE, LIQUID, SHARP, SMALL, PERFORATED, GRANULAR, SET, FC_PROVIDED, UNKNOWN, NONE, ITEM_BLANKSTK.
    /// </summary>
    /// <value>Type of preparation that should be done. Can be: ITEM_LABELING, ITEM_BUBBLEWRAP, ITEM_POLYBAGGING, ITEM_TAPING, ITEM_BLACK_SHRINKWRAP, ITEM_HANG_GARMENT, ITEM_BOXING, ITEM_SETCREAT, ITEM_RMOVHANG, ITEM_SUFFOSTK, ITEM_CAP_SEALING, ITEM_DEBUNDLE, ITEM_SETSTK, ITEM_SIOC, ITEM_NO_PREP, ADULT, BABY, TEXTILE, HANGER, FRAGILE, LIQUID, SHARP, SMALL, PERFORATED, GRANULAR, SET, FC_PROVIDED, UNKNOWN, NONE, ITEM_BLANKSTK.

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PrepType
    {
        /// <summary>
        /// Enum ITEM_LABELING for value: ITEM_LABELING
        /// </summary>
        [EnumMember(Value = "ITEM_LABELING")]
        ITEM_LABELING = 1,

        /// <summary>
        /// Enum ITEM_BUBBLEWRAP for value: ITEM_BUBBLEWRAP
        /// </summary>
        [EnumMember(Value = "ITEM_BUBBLEWRAP")]
        ITEM_BUBBLEWRAP = 2,

        /// <summary>
        /// Enum ITEM_POLYBAGGING for value: ITEM_POLYBAGGING
        /// </summary>
        [EnumMember(Value = "ITEM_POLYBAGGING")]
        ITEM_POLYBAGGING= 3,

        /// <summary>
        /// Enum ITEM_TAPING for value: ITEM_TAPING
        /// </summary>
        [EnumMember(Value = "ITEM_TAPING")]
        ITEM_TAPING= 4,

        /// <summary>
        /// Enum ITEM_BLACK_SHRINKWRAP for value: ITEM_BLACK_SHRINKWRAP
        /// </summary>
        [EnumMember(Value = "ITEM_BLACK_SHRINKWRAP")]
        ITEM_BLACK_SHRINKWRAP = 5,

        /// <summary>
        /// Enum ITEM_HANG_GARMENT for value: ITEM_HANG_GARMENT
        /// </summary>
        [EnumMember(Value = "ITEM_HANG_GARMENT")]
        ITEM_HANG_GARMENT = 6,

        /// <summary>
        /// Enum ITEM_BOXING for value: ITEM_BOXING
        /// </summary>
        [EnumMember(Value = "ITEM_BOXING")]
        ITEM_BOXING = 7,

        /// <summary>
        /// Enum ITEM_SETCREAT for value: ITEM_SETCREAT
        /// </summary>
        [EnumMember(Value = "ITEM_SETCREAT")]
        ITEM_SETCREAT = 8,

        /// <summary>
        /// Enum ITEM_RMOVHANG for value: ITEM_RMOVHANG
        /// </summary>
        [EnumMember(Value = "ITEM_RMOVHANG")]
        ITEM_RMOVHANG = 9,

        /// <summary>
        /// Enum ITEM_SUFFOSTK for value: ITEM_SUFFOSTK
        /// </summary>
        [EnumMember(Value = "ITEM_SUFFOSTK")]
        ITEM_SUFFOSTK = 10,

        /// <summary>
        /// Enum ITEM_CAP_SEALING for value: ITEM_CAP_SEALING
        /// </summary>
        [EnumMember(Value = "ITEM_CAP_SEALING")]
        ITEM_CAP_SEALING = 11,

        /// <summary>
        /// Enum ITEM_DEBUNDLE for value: ITEM_DEBUNDLE
        /// </summary>
        [EnumMember(Value = "ITEM_DEBUNDLE")]
        ITEM_DEBUNDLE = 12,

        /// <summary>
        /// Enum ITEM_SETSTK for value: ITEM_SETSTK
        /// </summary>
        [EnumMember(Value = "ITEM_SETSTK")]
        ITEM_SETSTK = 13,

        /// <summary>
        /// Enum ITEM_SIOC for value: ITEM_SIOC
        /// </summary>
        [EnumMember(Value = "ITEM_SIOC")]
        ITEM_SIOC = 14,

        /// <summary>
        /// Enum ITEM_NO_PREP for value: ITEM_NO_PREP
        /// </summary>
        [EnumMember(Value = "ITEM_NO_PREP")]
        ITEM_NO_PREP = 15,

        /// <summary>
        /// Enum ADULT for value: ADULT
        /// </summary>
        [EnumMember(Value = "ADULT")]
        ADULT = 16,

        /// <summary>
        /// Enum BABY for value: BABY
        /// </summary>
        [EnumMember(Value = "BABY")]
        BABY = 17,

        /// <summary>
        /// Enum TEXTILE for value: TEXTILE
        /// </summary>
        [EnumMember(Value = "TEXTILE")]
        TEXTILE = 18,

        /// <summary>
        /// Enum HANGER for value: HANGER
        /// </summary>
        [EnumMember(Value = "HANGER")]
        HANGER = 19,

        /// <summary>
        /// Enum FRAGILE for value: FRAGILE
        /// </summary>
        [EnumMember(Value = "FRAGILE")]
        FRAGILE = 20,

        /// <summary>
        /// Enum LIQUID for value: LIQUID
        /// </summary>
        [EnumMember(Value = "LIQUID")]
        LIQUID = 21,

        /// <summary>
        /// Enum SHARP for value: SHARP
        /// </summary>
        [EnumMember(Value = "SHARP")]
        SHARP = 22,

        /// <summary>
        /// Enum SMALL for value: SMALL
        /// </summary>
        [EnumMember(Value = "SMALL")]
        SMALL = 23,

        /// <summary>
        /// Enum PERFORATED for value: PERFORATED
        /// </summary>
        [EnumMember(Value = "PERFORATED")]
        PERFORATED = 24,

        /// <summary>
        /// Enum GRANULAR for value: GRANULAR
        /// </summary>
        [EnumMember(Value = "GRANULAR")]
        GRANULAR = 25,

        /// <summary>
        /// Enum SET for value: SET
        /// </summary>
        [EnumMember(Value = "SET")]
        SET = 26,

        /// <summary>
        /// Enum FC_PROVIDED for value: FC_PROVIDED
        /// </summary>
        [EnumMember(Value = "FC_PROVIDED")]
        FC_PROVIDED = 27,

        /// <summary>
        /// Enum UNKNOWN for value: UNKNOWN
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN = 28,

        /// <summary>
        /// Enum NONE for value: NONE
        /// </summary>
        [EnumMember(Value = "NONE")]
        NONE = 29,

        /// <summary>
        /// Enum ITEM_BLANKSTK for value: ITEM_BLANKSTK
        /// </summary>
        [EnumMember(Value = "ITEM_BLANKSTK")]
        ITEM_BLANKSTK = 30,
    }

}
