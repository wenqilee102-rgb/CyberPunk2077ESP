using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AlertedRoleHandler : AIbehaviortaskScript
	{
		private CBool _pathParamsModified;

		[Ordinal(0)] 
		[RED("pathParamsModified")] 
		public CBool PathParamsModified
		{
			get => GetProperty(ref _pathParamsModified);
			set => SetProperty(ref _pathParamsModified, value);
		}

		public AlertedRoleHandler(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
