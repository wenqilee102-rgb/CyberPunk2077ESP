using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetHUDHiddenRequest : gameScriptableSystemRequest
	{
		private CBool _hidden;

		[Ordinal(0)] 
		[RED("hidden")] 
		public CBool Hidden
		{
			get => GetProperty(ref _hidden);
			set => SetProperty(ref _hidden, value);
		}

		public SetHUDHiddenRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
