﻿using System.Xml.Serialization;

namespace GarantiVP
{

    /// <summary>
    /// Card information
    /// <para lang="tr">Kart bilgileri</para> 
    /// </summary>
    [XmlType(AnonymousType = true)]
    public class GVPSCard
    {
        /// <summary>
        /// Card number
        /// <para>Size numeric Min:15, Max:19 Byte</para>
        /// <para lang="tr">Kart numarası</para> 
        /// </summary>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Number { get; set; }

        /// <summary>
        /// Card expire date. Must be MMYY format.
        /// <para>Size 4 Byte</para>
        /// <para lang="tr">Kart son kullanım tarihi. AAYY biçiminde olmalı.</para> 
        /// </summary>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ExpireDate { get; set; }

        /// <summary>
        /// Card CVV number.
        /// <para>Size Min:3, Max:4 Byte (AMEX)</para>
        /// <para lang="tr">Kart CVV numarası</para> 
        /// </summary>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CVV2 { get; set; }

        /// <summary>
        /// Cardholder name
        /// <para lang="tr">Kart sahibi adı</para> 
        /// </summary>
        [XmlElement()]
        public string CardHolder { get; set; }
    }
}