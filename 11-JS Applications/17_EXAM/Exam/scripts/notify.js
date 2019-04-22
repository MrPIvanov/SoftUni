let notify = (() => {
  $(document).on({
    ajaxStart: () => $('#loadingBox').show(),
    ajaxStop: () => $('#loadingBox').fadeOut()
  })
  function showInfo (message) {
    let infoBox = $('#successBox')
    infoBox.text(message)
    infoBox.fadeIn()
    setTimeout(() => infoBox.fadeOut(), 5000)
  }

  function showError(message) {
    let errorBox = $('#errorBox')
    errorBox.text(message)
    errorBox.fadeIn()
    setTimeout(() => errorBox.fadeOut(), 5000)
  }

  function handleError (reason) {
    showError(reason.responseJSON.description)
  }

  return {
    showInfo,
    showError,
    handleError
  }
})()
