using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ExpansionErrorPopuppData : inkGameNotificationData
	{
		private CName _title;
		private CName _description;
		private CUInt32 _errorCode;

		[Ordinal(7)] 
		[RED("title")] 
		public CName Title
		{
			get => GetProperty(ref _title);
			set => SetProperty(ref _title, value);
		}

		[Ordinal(8)] 
		[RED("description")] 
		public CName Description
		{
			get => GetProperty(ref _description);
			set => SetProperty(ref _description, value);
		}

		[Ordinal(9)] 
		[RED("errorCode")] 
		public CUInt32 ErrorCode
		{
			get => GetProperty(ref _errorCode);
			set => SetProperty(ref _errorCode, value);
		}

		public ExpansionErrorPopuppData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
