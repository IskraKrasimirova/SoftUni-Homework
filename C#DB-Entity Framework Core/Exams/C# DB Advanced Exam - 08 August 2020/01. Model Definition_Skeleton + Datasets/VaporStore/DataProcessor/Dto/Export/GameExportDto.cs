﻿using System.Xml.Serialization;

namespace VaporStore.DataProcessor.Dto.Export
{
    [XmlType("Game")]
    public class GameExportDto
    {
        [XmlAttribute("title")]
        public string Title { get; set; }

        [XmlElement("Genre")]
        public string Genre { get; set; }

        [XmlElement("Price")]
        public decimal Price { get; set; }
    }
}

//<Users>
//  <User username="mgraveson">
//    <Purchases>
//      <Purchase>
//        <Card>7991 7779 5123 9211</Card>
//        <Cvc>340</Cvc>
//        <Date>2017-08-31 17:09</Date>
//        <Game title="Counter-Strike: Global Offensive">
//          <Genre>Action</Genre>
//          <Price>12.49</Price>
//        </Game>
//      </Purchase>