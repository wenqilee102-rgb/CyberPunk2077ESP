using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldCrowdNullAreaNode : worldAreaShapeNode
	{
		private CBool _isForBlockade;
		private CBool _permanentlyEnabledByDefault;

		[Ordinal(6)] 
		[RED("IsForBlockade")] 
		public CBool IsForBlockade
		{
			get => GetProperty(ref _isForBlockade);
			set => SetProperty(ref _isForBlockade, value);
		}

		[Ordinal(7)] 
		[RED("permanentlyEnabledByDefault")] 
		public CBool PermanentlyEnabledByDefault
		{
			get => GetProperty(ref _permanentlyEnabledByDefault);
			set => SetProperty(ref _permanentlyEnabledByDefault, value);
		}

		public worldCrowdNullAreaNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
