using System;
using System.IO;
using System.Net;

namespace Labo.DownloadManager.Protocol.Providers
{
    internal sealed class HttpProtocolProvider : INetworkProtocolProvider
    {
        private readonly IWebRequestManager m_WebRequestManager;

        public HttpProtocolProvider(IWebRequestManager webRequestManager)
        {
            m_WebRequestManager = webRequestManager;
        }

<<<<<<< HEAD
        public RemoteFileInfo GetRemoteFileInfo(DownloadFileInfo file)
=======
        public RemoteFileInfo GetRemoteFileInfo(DownloadFile file, out Stream stream)
>>>>>>> 6bb4df88966e7f0c08b9450197079385b2b1d098
        {
            RemoteFileInfo remoteFileInfo = new RemoteFileInfo();
            WebRequest webRequest = m_WebRequestManager.GetWebRequest(file);
            webRequest.Method = "HEAD";

            HttpWebResponse httpWebResponse = (HttpWebResponse) webRequest.GetResponse();
            remoteFileInfo.LastModified = httpWebResponse.LastModified;
            remoteFileInfo.MimeType = httpWebResponse.ContentType;
            remoteFileInfo.FileSize = httpWebResponse.ContentLength;
            remoteFileInfo.AcceptRanges = string.Compare(httpWebResponse.Headers["Accept-Ranges"], "bytes", StringComparison.OrdinalIgnoreCase) == 0;

            stream = httpWebResponse.GetResponseStream();

            return remoteFileInfo;
        }

        public Stream CreateStream(DownloadFileInfo file, long startPosition, long endPosition)
        {
            HttpWebRequest request = (HttpWebRequest)m_WebRequestManager.GetWebRequest(file);
            request.ServicePoint.ConnectionLimit = 5;

            if (startPosition != 0)
            {
                if (endPosition == 0)
                {
                    request.AddRange((int)startPosition);
                }
                else
                {
                    request.AddRange((int)startPosition, (int)endPosition);
                }
            }

            WebResponse response = request.GetResponse();

            return response.GetResponseStream();
        }
    }
}