using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IgnoreBarbedWirePrereq : gameIScriptablePrereq
	{
		private CFloat _minStateTime;
		private CBool _invert;

		[Ordinal(0)] 
		[RED("minStateTime")] 
		public CFloat MinStateTime
		{
			get => GetProperty(ref _minStateTime);
			set => SetProperty(ref _minStateTime, value);
		}

		[Ordinal(1)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetProperty(ref _invert);
			set => SetProperty(ref _invert, value);
		}

		public IgnoreBarbedWirePrereq(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
