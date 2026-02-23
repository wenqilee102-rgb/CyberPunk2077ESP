using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FrameSwitcherEvent : redEvent
	{
		private wCHandle<Frame> _frame;
		private CUInt32 _hash;
		private CInt32 _index;
		private RectF _uv;

		[Ordinal(0)] 
		[RED("frame")] 
		public wCHandle<Frame> Frame
		{
			get => GetProperty(ref _frame);
			set => SetProperty(ref _frame, value);
		}

		[Ordinal(1)] 
		[RED("hash")] 
		public CUInt32 Hash
		{
			get => GetProperty(ref _hash);
			set => SetProperty(ref _hash, value);
		}

		[Ordinal(2)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetProperty(ref _index);
			set => SetProperty(ref _index, value);
		}

		[Ordinal(3)] 
		[RED("uv")] 
		public RectF Uv
		{
			get => GetProperty(ref _uv);
			set => SetProperty(ref _uv, value);
		}

		public FrameSwitcherEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
