using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetIdleRazerAnimation_NodeTypeParams : CVariable
	{
		private CName _animationName;
		private CBool _use;

		[Ordinal(0)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetProperty(ref _animationName);
			set => SetProperty(ref _animationName, value);
		}

		[Ordinal(1)] 
		[RED("use")] 
		public CBool Use
		{
			get => GetProperty(ref _use);
			set => SetProperty(ref _use, value);
		}

		public questSetIdleRazerAnimation_NodeTypeParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
