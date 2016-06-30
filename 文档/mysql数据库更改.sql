alter table sline_member add column `pid` varchar(255) NULL DEFAULT '' after `mid`;

CREATE TABLE `sline_member_address`(
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `mid` int(11) NOT NULL COMMENT '会员id',
  `name` varchar(30) COLLATE utf8_bin DEFAULT NULL COMMENT '收货人姓名',
  `mobile` varchar(30) COLLATE utf8_bin DEFAULT NULL COMMENT '手机号码',
  `provid` int(11) DEFAULT '0' COMMENT '省份id',
  `province` varchar(50) COLLATE utf8_bin DEFAULT NULL COMMENT '省份',
  `cityid` int(11) DEFAULT '0' COMMENT '城市id',
  `city` varchar(50) COLLATE utf8_bin DEFAULT NULL COMMENT '城市',
  `countyid` int(11) DEFAULT '0' COMMENT '区县id',
  `county` varchar(50) COLLATE utf8_bin DEFAULT NULL COMMENT '区县',
  `addresshome` varchar(100) COLLATE utf8_bin DEFAULT NULL COMMENT '详细住址',
  `zip` varchar(20) COLLATE utf8_bin DEFAULT NULL COMMENT '邮编',
  `isdefault` int(3) DEFAULT '0' COMMENT '是否默认',
  `flag` int(3) DEFAULT '0' COMMENT '标识',
  PRIMARY KEY(`id`)
);

CREATE TABLE `sline_fenxiao_yongjin`(
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `grade` int(11) NOT NULL COMMENT '级别',
  `commision` decimal(10,3) DEFAULT NULL COMMENT '佣金比例',
  `remark` longtext COMMENT '备注说明',
  `isusing` int(3) DEFAULT '0' COMMENT '是否当前可用',
  `isinternal` int(3) DEFAULT '0' COMMENT '是否内部可用',
  `flag` int(3) DEFAULT '0' COMMENT '标识',
  `createtime` datetime default NULL COMMENT '创建时间',
  `createuser` int(11) default NULL COMMENT '创建人',
  `modifytime` datetime default NULL COMMENT '修改时间',
  `modifyuser` int(11) default NULL COMMENT '修改人',
  PRIMARY KEY (`id`)
);

CREATE TABLE `sline_region_province`(
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) COLLATE utf8_bin DEFAULT NULL COMMENT '名称',
  `alias` varchar(100) COLLATE utf8_bin DEFAULT NULL COMMENT '别名',
  `remark` longtext COMMENT '备注说明',
  PRIMARY KEY (`id`)
);

CREATE TABLE `sline_region_city`(
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `provid` int(1) DEFAULT '0' COMMENT '省id',
  `name` varchar(100) COLLATE utf8_bin DEFAULT NULL COMMENT '名称',
  `zip` varchar(20) COLLATE utf8_bin DEFAULT NULL COMMENT '邮编',
  `issubsite` int(3) DEFAULT '0' COMMENT '是否有子站',
  `remark` longtext COMMENT '备注说明',
  PRIMARY KEY (`id`)
);

CREATE TABLE `sline_region_county`(
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `cityid` int(1) DEFAULT '0' COMMENT '市id',
  `name` varchar(100) COLLATE utf8_bin DEFAULT NULL COMMENT '名称',
  `remark` longtext COMMENT '备注说明',
  PRIMARY KEY (`id`)
);


alter table sline_member_third add column `status` int(3) DEFAULT '1' COMMENT '账号状态' after `nickname`;
alter table sline_member_third add column `unsubscribetime` datetime DEFAULT NULL COMMENT '取消时间' after `nickname`;
alter table sline_member_third add column `subscribetime` datetime DEFAULT NULL COMMENT '关注时间' after `nickname`;
alter table sline_member_third add column `headimgurl` varchar(500) DEFAULT NULL COMMENT '头像地址' after `nickname`;

alter table sline_member modify column `pwd` char(32) NULL;
alter table sline_member modify column `truename` varchar(36) NULL;
alter table sline_member modify column `sex` enum('男','女','保密') NULL;
alter table sline_member modify column `rank` smallint(5) unsigned NULL;
alter table sline_member modify column `money` mediumint(8) unsigned NULL;
alter table sline_member modify column `email` char(50) NULL;
alter table sline_member modify column `mobile` varchar(15) NULL;
alter table sline_member modify column `jifen` mediumint(8) NULL;
alter table sline_member modify column `litpic` varchar(255) NULL;
alter table sline_member modify column `safequestion` varchar(255) NULL;
alter table sline_member modify column `safeanswer` char(30) NULL;
alter table sline_member modify column `jointime` int(10) unsigned NULL;
alter table sline_member modify column `joinip` char(16) NULL;
alter table sline_member modify column `logintime` int(10) unsigned NULL;
alter table sline_member modify column `loginip` char(16) NULL;
alter table sline_member modify column `checkmail` smallint(6) NULL;
