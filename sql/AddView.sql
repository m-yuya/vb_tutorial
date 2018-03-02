/***********************************/
/* 対象データベースの指定          */
/***********************************/
use [project_job]
GO

/****************************************/
/* 既存のビューの削除                   */
/* 存在する場合には削除する             */
/****************************************/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vw_projectlist]'))
DROP VIEW [dbo].[vw_projectlist]
GO
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vw_joblist]'))
DROP VIEW [dbo].[vw_joblist]
GO

/****************************************/
/* ビューの作成                         */
/****************************************/
CREATE VIEW [dbo].[vw_projectlist]
AS
SELECT  dbo.tbl_project.project_code, dbo.tbl_project.project_name, dbo.tbl_project.customer_code, dbo.tbl_project.staff_code,
            dbo.tbl_project.start_date, dbo.tbl_project.end_date, dbo.tbl_project.memo, dbo.tbl_project.complete_flag, 
            dbo.tbl_customer.customer_name, dbo.tbl_staff.staff_name, dbo.tbl_staff.staff_section
FROM    dbo.tbl_project LEFT OUTER JOIN
            dbo.tbl_staff ON dbo.tbl_project.staff_code = dbo.tbl_staff.staff_code LEFT OUTER JOIN
            dbo.tbl_customer ON dbo.tbl_project.customer_code = dbo.tbl_customer.customer_code
GO

PRINT '    project_job データベースに vw_projectlist ビュー(発展課題用に一部修正)を追加しました'
GO

CREATE VIEW [dbo].[vw_joblist]
AS
SELECT  dbo.tbl_job.job_title, dbo.tbl_staff.staff_name, dbo.tbl_staff.staff_section, dbo.tbl_project.project_name, 
            dbo.tbl_job.project_code, tbl_staff_1.staff_name AS manager, dbo.tbl_customer.customer_name, dbo.tbl_job.start_date, 
            dbo.tbl_job.end_date, dbo.tbl_job.complete_flag
FROM    dbo.tbl_job INNER JOIN
            dbo.tbl_staff ON dbo.tbl_job.staff_code = dbo.tbl_staff.staff_code INNER JOIN
            dbo.tbl_project ON dbo.tbl_job.project_code = dbo.tbl_project.project_code INNER JOIN
            dbo.tbl_staff AS tbl_staff_1 ON dbo.tbl_project.staff_code = tbl_staff_1.staff_code INNER JOIN
            dbo.tbl_customer ON dbo.tbl_project.customer_code = dbo.tbl_customer.customer_code
GO

PRINT '    project_job データベースに vw_joblist ビュー(発展課題用)を追加しました'
GO
