using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendOpacityMicromapChunk : CVariable
	{
		private CUInt32 _mChunkIndex;
		private CUInt32 _unkIndex;
		private CUInt64 _terialIdentifier;
		private CName _terialName;
		private CUInt64 _mDigest;
		private CUInt32 _mIndexBufferSize;
		private CUInt32 _mIndexBuffer16bit;
		private CUInt64 _mIndexBufferOffset;
		private CUInt64 _mArrayBufferOffset;
		private CUInt64 _mDescsBufferOffset;
		private CArray<rendOpacityMicromapUsageCounts> _mDescArrayHistogramData;
		private CArray<rendOpacityMicromapUsageCounts> _mIndexHistogramData;

		[Ordinal(0)] 
		[RED("mChunkIndex")] 
		public CUInt32 MChunkIndex
		{
			get => GetProperty(ref _mChunkIndex);
			set => SetProperty(ref _mChunkIndex, value);
		}

		[Ordinal(1)] 
		[RED("unkIndex")] 
		public CUInt32 UnkIndex
		{
			get => GetProperty(ref _unkIndex);
			set => SetProperty(ref _unkIndex, value);
		}

		[Ordinal(2)] 
		[RED("terialIdentifier")] 
		public CUInt64 TerialIdentifier
		{
			get => GetProperty(ref _terialIdentifier);
			set => SetProperty(ref _terialIdentifier, value);
		}

		[Ordinal(3)] 
		[RED("terialName")] 
		public CName TerialName
		{
			get => GetProperty(ref _terialName);
			set => SetProperty(ref _terialName, value);
		}

		[Ordinal(4)] 
		[RED("mDigest")] 
		public CUInt64 MDigest
		{
			get => GetProperty(ref _mDigest);
			set => SetProperty(ref _mDigest, value);
		}

		[Ordinal(5)] 
		[RED("mIndexBufferSize")] 
		public CUInt32 MIndexBufferSize
		{
			get => GetProperty(ref _mIndexBufferSize);
			set => SetProperty(ref _mIndexBufferSize, value);
		}

		[Ordinal(6)] 
		[RED("mIndexBuffer16bit")] 
		public CUInt32 MIndexBuffer16bit
		{
			get => GetProperty(ref _mIndexBuffer16bit);
			set => SetProperty(ref _mIndexBuffer16bit, value);
		}

		[Ordinal(7)] 
		[RED("mIndexBufferOffset")] 
		public CUInt64 MIndexBufferOffset
		{
			get => GetProperty(ref _mIndexBufferOffset);
			set => SetProperty(ref _mIndexBufferOffset, value);
		}

		[Ordinal(8)] 
		[RED("mArrayBufferOffset")] 
		public CUInt64 MArrayBufferOffset
		{
			get => GetProperty(ref _mArrayBufferOffset);
			set => SetProperty(ref _mArrayBufferOffset, value);
		}

		[Ordinal(9)] 
		[RED("mDescsBufferOffset")] 
		public CUInt64 MDescsBufferOffset
		{
			get => GetProperty(ref _mDescsBufferOffset);
			set => SetProperty(ref _mDescsBufferOffset, value);
		}

		[Ordinal(10)] 
		[RED("mDescArrayHistogramData")] 
		public CArray<rendOpacityMicromapUsageCounts> MDescArrayHistogramData
		{
			get => GetProperty(ref _mDescArrayHistogramData);
			set => SetProperty(ref _mDescArrayHistogramData, value);
		}

		[Ordinal(11)] 
		[RED("mIndexHistogramData")] 
		public CArray<rendOpacityMicromapUsageCounts> MIndexHistogramData
		{
			get => GetProperty(ref _mIndexHistogramData);
			set => SetProperty(ref _mIndexHistogramData, value);
		}

		public rendOpacityMicromapChunk(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
