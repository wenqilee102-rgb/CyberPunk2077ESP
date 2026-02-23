using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UpdatePlayerDevelopment : gamePlayerScriptableSystemRequest
	{
		private CBool _forceRefresh;

		[Ordinal(1)] 
		[RED("ForceRefresh")] 
		public CBool ForceRefresh
		{
			get => GetProperty(ref _forceRefresh);
			set => SetProperty(ref _forceRefresh, value);
		}

		public UpdatePlayerDevelopment(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
