using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkGameScreenshotInfo : CVariable
	{
		private CString _path;
		private CUInt64 _creationDate;
		private CUInt32 _aspectRatioType;
		private CUInt32 _pathHash;
		private CInt32 _screenshotIndex;
		private CBool _canBeDeleted;

		[Ordinal(0)] 
		[RED("path")] 
		public CString Path
		{
			get => GetProperty(ref _path);
			set => SetProperty(ref _path, value);
		}

		[Ordinal(1)] 
		[RED("creationDate")] 
		public CUInt64 CreationDate
		{
			get => GetProperty(ref _creationDate);
			set => SetProperty(ref _creationDate, value);
		}

		[Ordinal(2)] 
		[RED("aspectRatioType")] 
		public CUInt32 AspectRatioType
		{
			get => GetProperty(ref _aspectRatioType);
			set => SetProperty(ref _aspectRatioType, value);
		}

		[Ordinal(3)] 
		[RED("pathHash")] 
		public CUInt32 PathHash
		{
			get => GetProperty(ref _pathHash);
			set => SetProperty(ref _pathHash, value);
		}

		[Ordinal(4)] 
		[RED("screenshotIndex")] 
		public CInt32 ScreenshotIndex
		{
			get => GetProperty(ref _screenshotIndex);
			set => SetProperty(ref _screenshotIndex, value);
		}

		[Ordinal(5)] 
		[RED("canBeDeleted")] 
		public CBool CanBeDeleted
		{
			get => GetProperty(ref _canBeDeleted);
			set => SetProperty(ref _canBeDeleted, value);
		}

		public inkGameScreenshotInfo(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
