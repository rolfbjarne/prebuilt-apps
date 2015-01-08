// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;

namespace FieldService.iOS
{
	[Register ("AssignmentsController")]
	partial class AssignmentsController
	{
		[Outlet]
		UIKit.UITableView tableView { get; set; }

		[Outlet]
		UIKit.UIView activeAssignment { get; set; }

		[Outlet]
		UIKit.UIButton assignmentButton { get; set; }

		[Outlet]
		UIKit.UIImageView priorityBackground { get; set; }

		[Outlet]
		UIKit.UILabel priority { get; set; }

		[Outlet]
		UIKit.UILabel numberAndDate { get; set; }

		[Outlet]
		UIKit.UILabel titleLabel { get; set; }

		[Outlet]
		UIKit.UILabel startAndEnd { get; set; }

		[Outlet]
		FieldService.iOS.TextButton contact { get; set; }

		[Outlet]
		FieldService.iOS.TextButton address { get; set; }

		[Outlet]
		FieldService.iOS.StatusButton status { get; set; }

		[Outlet]
		UIKit.UIImageView timerBackgroundImage { get; set; }

		[Outlet]
		UIKit.UILabel timerLabel { get; set; }

		[Outlet]
		UIKit.UIButton record { get; set; }

		[Outlet]
		UIKit.UIImageView toolbarShadow { get; set; }

		[Action ("ActiveAssignmentSelected")]
		partial void ActiveAssignmentSelected ();

		[Action ("Record")]
		partial void Record ();

		[Action ("Address")]
		partial void Address ();
		
		void ReleaseDesignerOutlets ()
		{
			if (tableView != null) {
				tableView.Dispose ();
				tableView = null;
			}

			if (activeAssignment != null) {
				activeAssignment.Dispose ();
				activeAssignment = null;
			}

			if (assignmentButton != null) {
				assignmentButton.Dispose ();
				assignmentButton = null;
			}

			if (priorityBackground != null) {
				priorityBackground.Dispose ();
				priorityBackground = null;
			}

			if (priority != null) {
				priority.Dispose ();
				priority = null;
			}

			if (numberAndDate != null) {
				numberAndDate.Dispose ();
				numberAndDate = null;
			}

			if (titleLabel != null) {
				titleLabel.Dispose ();
				titleLabel = null;
			}

			if (startAndEnd != null) {
				startAndEnd.Dispose ();
				startAndEnd = null;
			}

			if (contact != null) {
				contact.Dispose ();
				contact = null;
			}

			if (address != null) {
				address.Dispose ();
				address = null;
			}

			if (status != null) {
				status.Dispose ();
				status = null;
			}

			if (timerBackgroundImage != null) {
				timerBackgroundImage.Dispose ();
				timerBackgroundImage = null;
			}

			if (timerLabel != null) {
				timerLabel.Dispose ();
				timerLabel = null;
			}

			if (record != null) {
				record.Dispose ();
				record = null;
			}

			if (toolbarShadow != null) {
				toolbarShadow.Dispose ();
				toolbarShadow = null;
			}
		}
	}
}
