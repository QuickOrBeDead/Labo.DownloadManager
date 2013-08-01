namespace Labo.DownloadManager.Tests
{
    public class DoubleBufferSegmentDownloadTaskTestFixture : BaseSegmentDownloadTaskTestFixture
    {
        protected override ISegmentDownloadTask CreateSegmentDownloadTask(int bufferSize, ISegmentDownloader segmentDownloader, ISegmentWriter segmentWriter)
        {
            return new DoubleBufferSegmentDownloadTask(bufferSize, segmentDownloader, segmentWriter);
        }
    }
}