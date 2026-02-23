using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetControllerLightColorRequest : gameScriptableSystemRequest
	{
		private CUInt8 _red;
		private CUInt8 _green;
		private CUInt8 _blue;
		private CBool _notQuest;

		[Ordinal(0)] 
		[RED("red")] 
		public CUInt8 Red
		{
			get => GetProperty(ref _red);
			set => SetProperty(ref _red, value);
		}

		[Ordinal(1)] 
		[RED("green")] 
		public CUInt8 Green
		{
			get => GetProperty(ref _green);
			set => SetProperty(ref _green, value);
		}

		[Ordinal(2)] 
		[RED("blue")] 
		public CUInt8 Blue
		{
			get => GetProperty(ref _blue);
			set => SetProperty(ref _blue, value);
		}

		[Ordinal(3)] 
		[RED("notQuest")] 
		public CBool NotQuest
		{
			get => GetProperty(ref _notQuest);
			set => SetProperty(ref _notQuest, value);
		}

		public SetControllerLightColorRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
