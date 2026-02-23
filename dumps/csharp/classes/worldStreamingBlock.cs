using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldStreamingBlock : CResource
	{
		private CArray<worldStreamingSectorDescriptor> _descriptors;
		private worldStreamingBlockIndex _index;

		[Ordinal(1)] 
		[RED("descriptors")] 
		public CArray<worldStreamingSectorDescriptor> Descriptors
		{
			get => GetProperty(ref _descriptors);
			set => SetProperty(ref _descriptors, value);
		}

		[Ordinal(2)] 
		[RED("index")] 
		public worldStreamingBlockIndex Index
		{
			get => GetProperty(ref _index);
			set => SetProperty(ref _index, value);
		}

		public worldStreamingBlock(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
