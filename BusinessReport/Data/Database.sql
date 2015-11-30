/*==============================================================*/
/* DBMS name:      MySQL 5.0                                    */
/* Created on:     11/30/2015 20:13:42                          */
/*==============================================================*/


drop table if exists BPSys_DataDic;

drop table if exists BPSys_DataDicDetail;

drop table if exists BPSys_Store;

drop table if exists BPSys_StoreSN;

drop table if exists BPSys_User;

drop table if exists Business_TransFlow;

drop table if exists Business_TransFlowCP;

/*==============================================================*/
/* Table: BPSys_DataDic                                         */
/*==============================================================*/
create table BPSys_DataDic
(
   ID                   char(36),
   Code                 varchar(64),
   Creator              varchar(32),
   CreatorID            char(36),
   CreatedTime          datetime
);

alter table BPSys_DataDic comment '数据字典';

/*==============================================================*/
/* Table: BPSys_DataDicDetail                                   */
/*==============================================================*/
create table BPSys_DataDicDetail
(
   ID                   char(36),
   Code                 varchar(64),
   Source               char(36),
   Creator              varchar(32),
   CreatorID            char(36),
   CreatedTime          datetime
);

alter table BPSys_DataDicDetail comment '数据字典明细';

/*==============================================================*/
/* Table: BPSys_Store                                           */
/*==============================================================*/
create table BPSys_Store
(
   ID                   char(36),
   Name                 varchar(64),
   Phone                varchar(16),
   Creator              varchar(32),
   CreatorID            char(36),
   CreatedTime          datetime
);

alter table BPSys_Store comment '门店信息';

/*==============================================================*/
/* Table: BPSys_StoreSN                                         */
/*==============================================================*/
create table BPSys_StoreSN
(
   ID                   char(36),
   StoreID              char(36),
   Name                 varchar(64),
   Code                 varchar(64),
   Status               tinyint comment '1 有效
            2 无效',
   Creator              varchar(32),
   CreatorID            char(36),
   CreatedTime          datetime
);

alter table BPSys_StoreSN comment '门店机器码信息';

/*==============================================================*/
/* Table: BPSys_User                                            */
/*==============================================================*/
create table BPSys_User
(
   ID                   char(36),
   LoginName            varchar(32),
   Name                 varchar(64),
   Password             varchar(64),
   Phone                varchar(16),
   StoreID              char(36),
   Status               tinyint comment '1 有效
            2 无效',
   Creator              varchar(32),
   CreatorID            char(36),
   CreatedTime          datetime
);

alter table BPSys_User comment '用户信息';

/*==============================================================*/
/* Table: Business_TransFlow                                    */
/*==============================================================*/
create table Business_TransFlow
(
   ID                   char(36),
   SN                   varchar(64),
   RunningNo            varchar(64),
   ExcTime              datetime,
   ExcSource            varchar(32),
   NetPay               decimal(11,2) comment '应付',
   Payable              decimal(11,2) comment '实付',
   Handling             decimal(11,2) comment '手续费',
   Statue               varchar(16),
   BankRunningNo        varchar(128),
   Creator              varchar(32),
   CreatorID            char(36),
   CreatedTime          datetime
);

alter table Business_TransFlow comment '交易流水数据';

/*==============================================================*/
/* Table: Business_TransFlowCP                                  */
/*==============================================================*/
create table Business_TransFlowCP
(
   ID                   char(36),
   SN                   varchar(64),
   RunningNo            varchar(64),
   ExcTime              datetime,
   ExcSource            varchar(32),
   NetPay               decimal(11,2) comment '应付',
   Payable              decimal(11,2) comment '实付',
   Handling             decimal(11,2) comment '手续费',
   Statue               varchar(16),
   BankRunningNo        varchar(128),
   Bid                  char(36),
   Creator              varchar(32),
   CreatorID            char(36),
   CreatedTime          datetime
);

alter table Business_TransFlowCP comment '交易流水数据临时比较数据';

