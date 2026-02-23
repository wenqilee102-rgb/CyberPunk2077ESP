using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class redTaskProgressMessage : CVariable
	{
		private CUInt32 _id;
		private CUInt32 _parent;
		private CFloat _progress;
		private CFloat _processingTime;

		[Ordinal(0)] 
		[RED("id")] 
		public CUInt32 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("parent")] 
		public CUInt32 Parent
		{
			get => GetProperty(ref _parent);
			set => SetProperty(ref _parent, value);
		}

		[Ordinal(2)] 
		[RED("progress")] 
		public CFloat Progress
		{
			get => GetProperty(ref _progress);
			set => SetProperty(ref _progress, value);
		}

		[Ordinal(3)] 
		[RED("processingTime")] 
		public CFloat ProcessingTime
		{
			get => GetProperty(ref _processingTime);
			set => SetProperty(ref _processingTime, value);
		}

		public redTaskProgressMessage(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
