using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPlayRazerAnimation_NodeTypeParams : CVariable
	{
		private CName _animationName;
		private CBool _loop;

		[Ordinal(0)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetProperty(ref _animationName);
			set => SetProperty(ref _animationName, value);
		}

		[Ordinal(1)] 
		[RED("loop")] 
		public CBool Loop
		{
			get => GetProperty(ref _loop);
			set => SetProperty(ref _loop, value);
		}

		public questPlayRazerAnimation_NodeTypeParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
