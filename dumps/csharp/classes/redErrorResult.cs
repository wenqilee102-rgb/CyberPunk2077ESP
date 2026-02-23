using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class redErrorResult : CVariable
	{
		private CString _message;
		private CVariant _userData;

		[Ordinal(0)] 
		[RED("message")] 
		public CString Message
		{
			get => GetProperty(ref _message);
			set => SetProperty(ref _message, value);
		}

		[Ordinal(1)] 
		[RED("userData")] 
		public CVariant UserData
		{
			get => GetProperty(ref _userData);
			set => SetProperty(ref _userData, value);
		}

		public redErrorResult(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
