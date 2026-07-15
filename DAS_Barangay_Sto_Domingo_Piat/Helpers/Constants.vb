Public Module Constants

    Public Const CURRENT_VERSION As String = "v2.00"

    Public Const UserType_Admin As String = "Admin"
    Public Const UserType_User  As String = "User"

    Public Const Status_Active   As String = "Active"
    Public Const Status_Inactive As String = "Inactive"

    Public Const Approval_ForReview As String = "For Review"
    Public Const Approval_Approved  As String = "Approved"
    Public Const Approval_Archived  As String = "Archived"

    Public ReadOnly DocumentTypes As String() = {
        "Financial Documents",
        "Legal Documents",
        "Human Resources (HR) Documents",
        "Project & Operational Documents",
        "Correspondence",
        "Intellectual Property",
        "Customer & Client Records",
        "Technical & Medical Records"
    }

End Module
