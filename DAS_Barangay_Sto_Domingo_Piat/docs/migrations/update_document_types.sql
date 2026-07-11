-- ============================================================
--  Migration: Remap tbl_Documents.DocumentType to the new category list
--  Run this ONCE against dasbsdp after deploying the updated
--  AdminNewDocumentForm / AdminUpdateDocumentForm / UserUploadDocumentPanel
--  dropdowns (see Helpers/Constants.vb -> DocumentTypes).
--
--  Old value        -> New value
--  ----------------------------------------------------------
--  Ordinance         -> Legal Documents
--  Resolution        -> Legal Documents
--  Budget Report     -> Financial Documents
--  Health Report     -> Technical & Medical Records
--  Infrastructure    -> Project & Operational Documents
--  Livelihood        -> Project & Operational Documents
--  Others            -> Correspondence
--
--  Review the mapping above before running — it is a judgment call.
--  Adjust the WHERE clauses if any of these should map differently.
-- ============================================================

USE dasbsdp;
GO

UPDATE tbl_Documents SET DocumentType = 'Legal Documents'                 WHERE DocumentType = 'Ordinance';
UPDATE tbl_Documents SET DocumentType = 'Legal Documents'                 WHERE DocumentType = 'Resolution';
UPDATE tbl_Documents SET DocumentType = 'Financial Documents'             WHERE DocumentType = 'Budget Report';
UPDATE tbl_Documents SET DocumentType = 'Technical & Medical Records'     WHERE DocumentType = 'Health Report';
UPDATE tbl_Documents SET DocumentType = 'Project & Operational Documents' WHERE DocumentType = 'Infrastructure';
UPDATE tbl_Documents SET DocumentType = 'Project & Operational Documents' WHERE DocumentType = 'Livelihood';
UPDATE tbl_Documents SET DocumentType = 'Correspondence'                 WHERE DocumentType = 'Others';

-- Verification: any rows left with a DocumentType outside the new list
-- need manual review (typos, legacy values not covered above, etc.)
SELECT DocumentID, DocumentCode, Title, DocumentType
FROM tbl_Documents
WHERE DocumentType NOT IN (
    'Financial Documents',
    'Legal Documents',
    'Human Resources (HR) Documents',
    'Project & Operational Documents',
    'Correspondence',
    'Intellectual Property',
    'Customer & Client Records',
    'Technical & Medical Records'
);

PRINT 'Document type migration complete.';
GO
