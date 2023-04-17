namespace drg_group.wlmq_2022{
    public class IB1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"A18.000x047+M49.0*","A18.000x048+M49.0*","A18.000x049+M49.0*","A18.000x066+M49.0*","A18.005+M49.0*","A18.006+M49.0*","A18.007+M49.0*","A18.008+M90.0*","A18.009+M49.0*","A18.010+M49.0*","A18.011+M49.0*","A18.012+M49.0*","A18.013+M49.0*","A23.901+M49.1*","B37.800x090","M08.100","M08.100x092","M40.000x091","M40.100x051","M40.101","M40.200x021","M40.200x041","M40.200x061","M40.201","M40.401","M40.402","M40.500","M41.000","M41.101","M41.200","M41.300","M41.400x091","M41.401","M41.501","M41.800","M41.900","M41.900x061","M41.901","M43.901","M45.x01","M45.x02","M45.x03+H22.1*","M46.200x021","M46.200x041","M46.200x061","M46.300x021","M46.300x041","M46.300x061","M46.301","M46.302","M46.401","M46.402","M46.403","M46.500x091","M46.500x092","M46.501","M46.502","M46.503","M46.504","M46.800x091","M46.800x093","M46.802","M46.803","M46.900","M48.001","M48.002","M48.003","M48.004","M48.305","M48.811","M96.200","M96.300","M96.400","M96.500","M99.200x001","M99.200x002","M99.200x003","M99.300x001","M99.300x002","M99.300x003","M99.400x001","M99.400x002","M99.400x003","M99.500x001","M99.500x002","M99.500x003","M99.600","M99.700x002","Q67.500","Q67.501","Q67.502","Q67.503","Q76.000x002","Q76.000x003","Q76.000x004","Q76.000x005","Q76.200","Q76.200x103","Q76.201","Q76.202","Q76.203","Q76.300","Q76.300x011","Q76.400x101","Q76.400x102","Q76.400x201","Q76.400x203","Q76.400x203","Q76.400x301","Q76.400x302","Q76.400x303","Q76.400x304","Q76.400x305","Q76.400x307","Q76.400x308","Q76.400x310","Q76.400x313","Q76.400x324","Q76.400x903","Q76.400x906","Q76.402","Q76.403","Q76.404","Q76.407","Q76.408","Q76.409","Q76.412","Q76.413","Q76.414","Q76.415","Q76.416","Q76.417","Q76.418"};
            String[] adrg_zd1={};
            String[] adrg_ss={"03.0900x025","03.0900x026","03.0900x027","03.0900x028","77.6900x032","77.6900x055","77.6906","77.8909","77.9900x004","78.0900x008","78.0900x009","78.0900x015","78.0900x018","80.5100x008","80.5100x011","80.5100x023","80.5100x024","80.5100x025","80.5100x026","80.5100x027","80.5100x028","80.5100x029","80.5100x030","80.5100x031","80.5100x032","80.5101","80.5102","80.5103","80.5104","80.5105","80.5106","80.5200","80.5400x001","80.5900x001","80.5900x003","80.9900x003","80.9900x006","80.9901","80.9902","80.9903","81.0200x001","81.0200x002","81.0300x001","81.0300x002","81.0400x004","81.0400x005","81.0401","81.0402","81.0500x005","81.0500x006","81.0501","81.0502","81.0600x005","81.0600x006","81.0601","81.0602","81.0700x002","81.0701","81.0702","81.0800x016","81.0800x017","81.0800x018","81.0801","81.0802","84.5900x002","84.6101","84.6201","84.6300x002","84.6300x003","84.6301","84.6600x001","84.6601","84.6700x002","84.6701"};
            String[] adrg_ss1={"03.0900x007","03.0900x023","03.0900x024","03.5303","79.8904","81.0100x001","81.0101","81.0102","81.0103","81.0104","81.0105","81.3101","81.3102","81.3103","81.3104","81.3105","81.3106","81.3200x001","81.3200x002","81.3300x001","81.3300x002","81.3400x003","81.3400x004","81.3401","81.3402","81.3500x003","81.3500x004","81.3501","81.3502","81.3600x003","81.3600x004","81.3601","81.3602","81.3700x001","81.3700x002","81.3701","81.3702","81.3800x003","81.3800x004","81.3800x005","81.3801","81.3802","81.3900","81.6300","81.6400x003"};
            
            if (true && adrg_zd.Contains(record.zdList[0]) && record.ssList!=null &&record.ssList.Length>0 && Base.intersect(record.ssList,adrg_ss) && Base.intersect(record.ssList,adrg_ss1)){
                Base.groupMessages.putMessage(record.Index,"符合IB1入组条件，匹配规则：主诊断匹配、双手术匹配");
                    
                if (MDCI_DRG.IB19_group(record))
                {
                    return "IB19";
                }

                return "IB1";
            }else{
                return "";
            }
        }
    }
}