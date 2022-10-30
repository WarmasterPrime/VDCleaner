using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDCleaner
{
	public class FileOrganizations
	{

		/*
		 bool img=q=="png"||q=="jpg"||q=="jpeg"||q=="webp"||q=="gif"||q=="svg";
				bool doc=q=="doc"||q=="docx"||q=="pdf"||q=="xl"||q=="csv"||q=="ppt"||q=="txt"||q=="rtf"||q=="odt"||q=="tex"||q=="wpd"||q=="word"||q=="ixl"||q=="exl"||q=="info"||q=="nfo";
				bool video=q=="mp4"||q=="mov"||q=="mkv"||q=="m4a"||q=="asf"||q=="wma"||q=="wmv"||q=="wm"||q=="avi"||q=="ogg"||q=="m4a4";
				bool audio=q=="mp3"||q=="m4a";
				bool font=q=="ttf"||q=="oft";
				bool exe=q=="exe";
				bool code=q=="cs"||q=="php"||q=="js"||q=="json"||q=="html"||q=="css"||q=="py"||q=="cpp"||q=="sl"||q=="c";
				bool lnk=q=="lnk"||q=="shortcut";
				bool ini=q=="ini";
				bool obj=q=="obj"||q=="glb"||q=="3mf"||q=="mtl";
				bool arch=q=="zip"||q=="archive"||q=="rar"||q=="tor";
		*/

		public static Dictionary<string,List<string>>Items=new Dictionary<string,List<string>>
		{
			{ "img",new List<string> {"png","jpg","jpeg","webp","gif","svg","jxl","bif","bmp","dcm","dcx","ddb","dds","ddt","dgt","dib","dic","dicom","dmi","hdr","hdp","heic","heif","icon","ink","pic","pix","pjpeg","pjpg","psd","rgb","rgba","ras","tif","tiff","dng","raw","ai","xar","ink","pmg","pen","svm","wpg","cvs","dhs","wpi","emf","ovr","dcs","art" } },
			{ "text",new List<string> {"doc","docx","pdf","txt","rtf","odt","tex","wpd","word","info","nfo","_doc","_docx","adoc","ascii","asc","bml","docm","docz","dox","etf","gdoc","gform","log","license","me","readme","iplog","note","pages","pages-tef","plain","rft","ris","rpt","rst","rtd","saf","text","utf" } },
			{ "table",new List<string> {"cts","xls","xlsx","xlsm","def","123","dex","xl","xlr","pmvx","numbers","numbers-tef","sxc","nb","xlsb","ods","gnumeric","mar","ots","chip","fods","presto","cell","bks","rdf","xar","_xls","tmv","imp","efu","pmd","wq2","sdc","xltx","edxz","_xlsx","gsheet","ast","edx","aws","wls" } },
			{ "obj",new List<string> {"3d","anim","bif","bio","bip","bld","blend","blk","caf","cas","cal","cfg","cmf","dmc","dif","fig","fnc","glb","glf","hip","hlsl","mat","makerbot","mesh","mix","msh","obj","obp","obz","oct","off","ogf","par","part","phy","rad","rig","thing","vox" } },
			{ "compressed",new List<string> {"pkg","zip","archive","tor","torrent","rar" } },
			{ "audio",new List<string> {"aif","mp3","aud","band","bank","dmc","dsm","efq","fpa","gig","groove","jam","logic","logicx","mid","midi","m4a","mp2","mpa","mpga","mus","mux","ogg","opus","ots","ove","oga","odm","song","wav","weba","wave","jar" } },
			{ "video",new List<string> {"aec","amc","amv","amx","anm","av","cam","dvr","dvd","flv","gifv","h263","h264","h265","hdmov","hdv","hevc","imovielibrary","imoviemobile","imovieproj","imovieproject","imovie","jdr","media","mep","meps","mepx","meta","mjpeg","mjpg","mkv","mod","movie","mov","mpeg","mpeg4","mp5","mpe","mpg","mpv","msdvd","mvc","ogm","ogv","ogx","orv","pmp","pmf","rmp","rsx","theater","thp","tid","tivo","tix","tmv","trec","tvs","video","vid","vii","viv","vix","vlab","vro","webm","wgi","wlmp","wm","wmd","wmmp","wmv","wmx","wot","wp3","zoom","vlc" } },
			{ "exe",new List<string> {"0xe","73k","73p","89k","89z","8ck","a6p","a7r","ac","acc","acr","actc","action","actm","afmacro","afmacros","ahk","air","apk","app","appimage","applescript","arscript","asb","atmx","bat","batch","bin","bms","btm","caction","cel","cfs","cgi","cheat","cmd","cof","coffee","com","command","csh","cyw","dek","dld","dmc","ds","dxl","e_e","ear","ebacmd","ebm","ebs","ebs2","ecf","eham","elf","epk","es","esh","ex4","ex5","exe","exe1","exopc","ezs","ezt","fas","fba","gadget","gpu","ham","icd","mac","jar","mam","mamc","mel","mem","osx","paf","paf.exe","run","rxe","scr","script","sct","seed","server","sh","snap","widget" } },
			{ "lnk",new List<string> {"lnk","shortcut","http","url" } },
			{ "font",new List<string> {"ttf","otf" } },
			{ "code",new List<string> {"html","js","css","php","cs","cpp","c","py","swift","sw","java","json","xml","htdocs","htdoc","apache","db","sql","mysql","mdb","mariadb","mssql","msdb","iis","unity","ino","class","git","bas","sl","sln","bcp","cc","config","csproject","csproj","dbo","lib","lua","nupkg","patch","vbproj","vbproject","vcproj","vcproject","xaml","yaml","yml" } },
			{ "sys",new List<string> {"sys","dll","0","000","1","2","208","2fs","3","386","3fs","4","5","6","7","73u","8","bin","blf","bmk","bom","bud","c32","cab","cannedsearch","cap","cat","cdmp","cgz","chg","chk","cmo","configprofile","cpi","cpl","cpq","cpr","crash","cur","customdestination","customdestination-ms","dat","database_uuid","desklink","deskthemepack","dev","devicemetadata-ms","dfu","diagcab","diagcfg","diagpkg","dic","diffbase","dimax","dit","dlx","dmp","dock","drpm","drv","dss","dthumb","dub","dvd","dyc","efi","edj","ebd","dyc","elf","firm","fid","ffa","ffl","ffo","evtx","evt","etl","emerald","escopy","fpbf","ftf","ftg","ftr","fts","fx","gmmp","grl","group","grp","h1s","hcd","hdmp","help","hhc","hhk","hiv","hlp","hpj","hsh","htt","hve","icl","icns","ico","iconpackage","idi","idx","ifw","im4p","ins","inf","ime","img3","internetconnect","ion","ioplist","ipod","iptheme","itemeta-ms","its","jetkey","job","jpn","kbd","kext","kor","ks","kwi","lex","lfs","library-ms","lm","localized","lockfile","log1","log2","lpd","lst","manifest","mapimail","mbn","mbr","mdmp","me","mem","menu","metadata_never_index","mlc","mobileconfig","mod","msc","msp","msstyle","msstyles","mtz","mui","mum","ntfs","nt","ozip","panic","pat","pdr","pid","pit","profile","prf","pro","prop","pwl","push_device","reg","reglnk","rfw","roku","rs","ruf","rvp","savedsearch","saver","sb","sbf","sbn","scap","scf","schemas","schema","scr","sdb","sdt","sefw","self","service","sfcache","swp","spx","theme","thumbnails","timer","trashes","tashinfo","trx_dll","vga","vgd","vx_","vxd","wdf","wdgt","webpnp","wer","wgz","wlu","wph","wpx","xfb","xrm-ms","ini" } },
			{ "settings",new List<string> {"aco","abs","act","acv","asl","aux","cfg","cnf","cmp","clr","clg","chx","conf","comp","cos","costyle","cpg","cpr","cps","dar","directory","dinfo","dicproof","deft","ds_store","dsw","ehi","gid" } },
			{ "encoded",new List<string> {"bin","bip","bit","bfa","bca","bfe","bpk","bsk","bvd","ccd","cef","cng","cpt","crypt","dlc","enc","hex","hid","htpasswd","idea","iwa","jac","kde","kkk","kxx","locked" } },
			{ "game",new List<string> {"bns","umx","osr","mii","sc2assets","sims3pack","dek","rep","npa","usx","u8","kodu","w3n","pss","osz","vpk","gbx","bo2","sfar","mca","mgx","scworld","pxp","ddt","sami","unity3d","wld","sims3","bfs","w3x","bzw","p3t","lrf","pcc","honmod","gen","mcstructure","age3sav","mcworld","gba","papa","ydc","zs4","ess","osk","age3ysav","ttr","vrcw","xom","zs5","arch00","isr","rez","xpd","wz","wtd","zs9","b","forge","gcm","v64","sii","gma","mp2s","package","nds","ydr","mcr","unr","mpm","ain","schematic","gsc","lvl","w3m","zs2","unitypackage","dem","z64","ycm","z4","tbm","dek","gmres","smrailroadssavedgame","mrs","wotreplay","upk","save","nar","bmz","age3scn","esm","h4r","scs","gbc","smc","mis","crp","litemod","pck","esp","svs","cgz","sc2replay","lmu","am1","tor","wad","xp3","sfc","plr","bsp","ltx","dazip","cdp","zs0","pwf","wowsreplay","bin","scs","sc2save","3dsx","vmf","uasset","fps","menu","gb","ct","vdf","pak","mcserver","lsd","mp2m","sc4","w3g","acww","dat","sfo","splane","rvdata","sc2map","mcpack","pgn","pk3","dat_new","aao","big","info","vtf","n64","spc","gam","grf","psv","mpq","wtf","pkg","wad","rep","xpk","bmd","s2z","nes","mdl","3ds","ipl","ff","pbp","gdg","gbaskin","masseffectsave","rpl","saber","sc2mod","frz","bin","sha","prk","sli","kv3","lsl","xs","rgss3a","gms","pqhero","ztd","ztmp","game","mgl","bsa","sg0","zs7","rttex","idx0","pup","sc2archive","pex","zs6","project","dsg","stencyl","j2l","ut4mod","luxb","sc2ma","sdz","nltrack","mae","age3xsav","arp","zs3","acf","sav","ttarch","sav","world","spb","nro","iwd","sgm","rvz","fgd","sims2pack","mas","compiled","map","utx","bps","blp","bar","esp","tim","qc","rxdata","nsz","jap","srm","m2","cgf","sm","mahjongtitanssave-ms","cpn","bif","uc","fuk","vmv","bfg","bsb","xci","age3rec","sc4desc","carc","rgssad","usa","bin","usm","w3z","sid","vfs0","fssave","brf","xmb","eng","wotbreplay","mwl","course","sad","chd","wbt","n3pmesh","world","scx","u","bus","vol","rvdata2","jmf","wam","dek","zs1","mstxt","z3","cbv","dmb","ibt","68k","dl","ldw","hot","bik","sqf","blz","ydk","udk","fml","md2","cxi","ssc","sav","fomod","lmp","mcapm","scm","map","ted","far","rvproj","age3xrec","gdi","world","emd","adt","bls","zmap","ngage","esm","unityproj","fcs","sta","dif","phn","dm_83","vcm","gdshader","csb","ngp","pkx","dv2","lss","brres","sga","rfm","schem","xnb","ips","pssg","raw","img","bejeweled2deluxesavedgame","ba2","0","uxx","bgl","narc","stormreplay","ukx","clip","scx","wdb","fos","wz","ut3","md3","escape","swc","zip","zst","xen","lgp","tiger","cbh","smzip","umd","ups","galaxy","ntrk","h3m","dol","gr2","pln","sc2bank","omod","nsbmd","001","gcf","age3yrec","sgb","ut2mod","unf","ovh","dec","pcsav","rom","elf","chk","hum","z5","utc","pod","z2f","plr","sc4lot","scn","fsm","vb","duc","pk4","zblorb","mgx","vob","player","erf","hps","love","sgf","replay","wagame","dm2","ns1","mis","h5u","j2i","fpg","esg","egm","msproj","sc2data","fl","pssl","fcm","cty","masseffectprofile","dns","bookwormdeluxesavedgame","dnf","dm_82","g3x","bme","sgpbprj","gbcskin","mul","vmv","shader","sdt","maplet","ll","dem","fs2","gpf","idx255","vrmanifest","lsw","gfx","rgd","asr","dun","tim","bo3","radq","qwd","bms","lip","nca","blasterball3savedgame","kwreplay","dm_84","blackhawkstriker2","zds","umod","playmission","puz","ctx","ncf","twt","wbox","dmo","esl","wu8","nsbtx","ecw","pbn","scn","jg4","toc","sav","sud","minesweepersave-ms","soepsx","e2gm","fst","nl2script","bnk","ac","zs8","jst","blorb","sd7","sprite","whirld","cdp2","rpgproject","wal","nsbca","erb","xds","srl","sqm","ut2","uvx" } },
			{ "danger",new List<string> {"aaa","adame","adobe","aurora","bc5b","bip","kkk","kxx","locked","blower","cadq","carote","cerber","cerber2","conti","coot","crypt","crypt1","ctbl","ded","dharma","djvu","djvus","eegf","eewt","wfdc","eiur","encrypted","fc","fonix","fun","gdcb","gero","givemenitro","good","hoop","krab","lilith","lilocked","locked","locky","lqqw","lucy","maas","merry","micro","nbes","nmo","null","odin","paradise","poop","purge","qewe","qscx","r2u","r5a","radman","rap","rcrypted","repp","rrbb","rumba","ryk","sage","salma","ssoi","sspq","stop","u2k","uiwix","voom","vtym","wallet","werd","wiot","wlu","wrui","xtbl","xxx","ykcol","zzzzz" } }
			
		};

		public static Dictionary<string,List<string>> Categories=new Dictionary<string, List<string>>
		{
			{ "file",new List<string> {"img","text","obj","compressed","table","audio","video","exe","lnk","font","code","settings","sys","encoded","game","danger" } },
			{ "document",new List<string> {"text","table" } },
			{ "media",new List<string> {"img","audio","video" } },
			{ "program",new List<string> {"exe","lnk" } }
		};

		public static bool IsFile(string value)
		{
			bool res=false;
			if(value.CheckValue())
			{
				foreach(var sel in Items)
					if(sel.Value.Contains(value)&&sel.Key=="img"||sel.Key=="text"||sel.Key=="audio"||sel.Key=="video"||sel.Key=="table"||sel.Key=="compressed")
					{
						res=true;
						break;
					}
			}
			return res;
		}






	}
}
