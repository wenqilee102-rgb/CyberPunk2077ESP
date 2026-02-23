using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendOpacityMicromapDatabase : CVariable
	{
		private CArray<rendOpacityMicromapChunk> _ommChunks;
		private CArray<CUInt8> _dataBuffer;

		[Ordinal(0)] 
		[RED("ommChunks")] 
		public CArray<rendOpacityMicromapChunk> OmmChunks
		{
			get => GetProperty(ref _ommChunks);
			set => SetProperty(ref _ommChunks, value);
		}

		[Ordinal(1)] 
		[RED("dataBuffer")] 
		public CArray<CUInt8> DataBuffer
		{
			get => GetProperty(ref _dataBuffer);
			set => SetProperty(ref _dataBuffer, value);
		}

		public rendOpacityMicromapDatabase(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
