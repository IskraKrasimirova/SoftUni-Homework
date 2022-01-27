﻿using MyWebServer.Server.HTTP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebServer.Server.Responses
{
    public class FileResponse : Response
    {
        public string FileName { get; init; }

        public FileResponse(string fileName)
            : base(StatusCode.OK)
        {
            this.FileName = fileName;

            this.Headers.Add(Header.ContentType, ContentType.FileContent);
        }

        public override string ToString()
        {
            if (File.Exists(this.FileName))
            {
                this.Body = String.Empty;
                FileContent = File.ReadAllBytes(this.FileName);

                var fileBytesCount = new FileInfo(this.FileName).Length;

                this.Headers.Add(Header.ContentLength, fileBytesCount.ToString());
                this.Headers.Add(Header.ContentDisposition, $"attachment; filename=\"{this.FileName}\"");
            }

            return base.ToString();
        }
    }
}
