using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EnableAutoDriveRequest : gameScriptableSystemRequest
	{
		private CBool _isDelamain;

		[Ordinal(0)] 
		[RED("isDelamain")] 
		public CBool IsDelamain
		{
			get => GetProperty(ref _isDelamain);
			set => SetProperty(ref _isDelamain, value);
		}

		public EnableAutoDriveRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
