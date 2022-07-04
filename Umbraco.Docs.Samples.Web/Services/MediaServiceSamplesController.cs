﻿using Umbraco.Cms.Web.Common.Controllers;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.IO;
using Umbraco.Cms.Core.Strings;
using Umbraco.Cms.Core.Serialization;
using Umbraco.Cms.Core.PropertyEditors;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace Umbraco.Docs.Samples.Web.Services
{
    // https://our.umbraco.com/Documentation/Reference/Management/Services/MediaService/Index/
    public class MediaServiceSamplesController : UmbracoApiController
    {
        private MediaFileManager _mediaFileManager;
        private IShortStringHelper _shortStringHelper;
        private IContentTypeBaseServiceProvider _contentTypeBaseServiceProvider;
        private IJsonSerializer _serializer;
        private MediaUrlGeneratorCollection _mediaUrlGeneratorCollection;
        private IMediaService _mediaService;
        private readonly IWebHostEnvironment _webHostEnvironment;


        public MediaServiceSamplesController(MediaFileManager mediaFileManager, IShortStringHelper shortStringHelper, IContentTypeBaseServiceProvider contentTypeBaseServiceProvider, IJsonSerializer serializer, MediaUrlGeneratorCollection mediaUrlGeneratorCollection, IMediaService mediaService, IWebHostEnvironment webHostEnvironment)
        {
            _mediaFileManager = mediaFileManager;
            _shortStringHelper = shortStringHelper;
            _contentTypeBaseServiceProvider = contentTypeBaseServiceProvider;
            _serializer = serializer;
            _mediaUrlGeneratorCollection = mediaUrlGeneratorCollection;
            _mediaService = mediaService;
            _webHostEnvironment = webHostEnvironment;
        }

        // /Umbraco/Api/MediaServiceSamples/CreateMediaFolder
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public Microsoft.AspNetCore.Mvc.ActionResult<string> CreateMediaFolder()
        {
            // Initialize a new media at the root of the media archive
            IMedia folder = _mediaService.CreateMedia("Samples Media Item Folder", Constants.System.Root, Constants.Conventions.MediaTypes.Folder);

            // Save the folder
            var result = _mediaService.Save(folder);

            return result.Success.ToString();
        }


        // /Umbraco/Api/MediaServiceSamples/CreateMediaImage
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public Microsoft.AspNetCore.Mvc.ActionResult<string> CreateMediaImage()
        {
            string webRootPath = _webHostEnvironment.WebRootPath;
            var path = Path.Combine(webRootPath, "images", "unicorn.jpg");


            // Open a new stream to the file
            using (Stream stream = System.IO.File.OpenRead(path))
            {
                // Initialize a new image at the root of the media archive
                IMedia media = _mediaService.CreateMedia("My image", Constants.System.Root, Constants.Conventions.MediaTypes.Image);
                // Set the property value (Umbraco will handle the underlying magic)
                media.SetValue(_mediaFileManager, _mediaUrlGeneratorCollection, _shortStringHelper, _contentTypeBaseServiceProvider, "umbracoFile", "my-image.jpg", stream);
                // Save the media
                var result = _mediaService.Save(media);

                return result.Success.ToString();
            }
        }
    }
}
